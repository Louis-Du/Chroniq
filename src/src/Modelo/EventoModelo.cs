using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace src.Modelo
{
    // Capa de acceso a datos para la colección "Eventos" de MongoDB.
    public class EventoModelo
    {
        // Retorna un evento por su _id; null si no existe o hay error.
        public Evento ObtenerEventoPorId(string idEvento)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<Evento>("Eventos");
                var filtro = Builders<Evento>.Filter.Eq(e => e.Id, idEvento);
                return collection.Find(filtro).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Inserta un evento nuevo con estadoevento "habilitado"; retorna su _id o null si hay conflicto.
        public string GuardarEvento(string nombreEvent, string tipoEvent, string fechahoraIniEvent,
            string fechahoraFinEvent, string idLider)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");

                // Hay conflicto si otro evento activo comienza antes de que éste termine
                // Y termina después de que éste empiece (solapamiento de horarios).
                var filtroConflicto = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Ne("estadoevento", "inhabilitado"),
                    Builders<BsonDocument>.Filter.Lt("fechahoraIniEvent", fechahoraFinEvent),
                    Builders<BsonDocument>.Filter.Gt("fechahoraFinEvent", fechahoraIniEvent)
                );

                if (collection.Find(filtroConflicto).Any())
                    return null; // Conflicto: no se puede guardar el evento.

                // El código de evento se basa en el total de documentos existentes + 1.
                int codigoEvent = (int)collection.CountDocuments(new BsonDocument()) + 1;

                var documento = new BsonDocument
                {
                    { "codigoEvent",       codigoEvent },
                    { "nombreEvent",       nombreEvent },
                    { "tipoevent",         tipoEvent },
                    { "fechahoraIniEvent", fechahoraIniEvent },
                    { "fechahoraFinEvent", fechahoraFinEvent },
                    { "creadoPor",         new ObjectId(idLider) },
                    { "invitados",         new BsonArray() },
                    // Sin este campo "estadoevento", los filtros Ne("inhabilitado") no
                    // incluirían el evento en las consultas posteriores.
                    { "estadoevento",      "habilitado" }
                };

                collection.InsertOne(documento);
                return documento["_id"].AsObjectId.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Retorna eventos cuya fecha de inicio es >= fechaActual y no están inhabilitados.
        public List<Evento> ObtenerEventos(string fechaActual)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<Evento>("Eventos");

                // Ne("inhabilitado") en lugar de Eq("habilitado") para incluir también
                // eventos que no tienen el campo estadoevento (datos históricos previos a esta feature).
                var filtro = Builders<Evento>.Filter.And(
                    Builders<Evento>.Filter.Gte("fechahoraIniEvent", fechaActual),
                    Builders<Evento>.Filter.Ne("estadoevento", "inhabilitado")
                );

                return collection.Find(filtro).ToList();
            }
            catch (Exception)
            {
                return new List<Evento>();
            }
        }

        // Agrega idInvitado al array "invitados" del evento; retorna false si ya está o hay conflicto de horario.
        public bool AgregarInvitado(string idEvento, string idInvitado,
            string fechahoraIniEvent, string fechahoraFinEvent)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");

                // Validamos que los strings de id sean ObjectIds válidos antes de usarlos.
                if (!ObjectId.TryParse(idInvitado, out ObjectId invitadoObjectId)) return false;
                if (!ObjectId.TryParse(idEvento,   out ObjectId eventoObjectId))   return false;

                // Verifica que el invitado no esté ya inscrito en este mismo evento.
                var filtroYaAgregado = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("_id", eventoObjectId),
                    Builders<BsonDocument>.Filter.AnyEq("invitados", invitadoObjectId)
                );
                if (collection.Find(filtroYaAgregado).Any()) return false;

                // Verifica que el invitado no tenga otro evento activo en el mismo rango de horas.
                var filtroConflicto = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.AnyEq("invitados", invitadoObjectId),
                    Builders<BsonDocument>.Filter.Ne("estadoevento", "inhabilitado"),
                    Builders<BsonDocument>.Filter.Lt("fechahoraIniEvent", fechahoraFinEvent),
                    Builders<BsonDocument>.Filter.Gt("fechahoraFinEvent", fechahoraIniEvent)
                );
                if (collection.Find(filtroConflicto).Any()) return false;

                // $push agrega el id al array sin borrar los elementos existentes.
                var filtroEvento  = Builders<BsonDocument>.Filter.Eq("_id", eventoObjectId);
                var actualizacion = Builders<BsonDocument>.Update.Push("invitados", invitadoObjectId);
                collection.UpdateOne(filtroEvento, actualizacion);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Retorna eventos futuros donde el usuario (invitado) está inscrito y el evento está habilitado.
        public List<Evento> ObtenerEventosPorInvitado(string idUsuario)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<Evento>("Eventos");
                string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (!ObjectId.TryParse(idUsuario, out ObjectId objectIdUsuario))
                    return new List<Evento>();

                // AnyEq busca dentro del array "invitados" si contiene el ObjectId del usuario.
                var filtro = Builders<Evento>.Filter.And(
                    Builders<Evento>.Filter.AnyEq("invitados", objectIdUsuario),
                    Builders<Evento>.Filter.Ne("estadoevento", "inhabilitado"),
                    Builders<Evento>.Filter.Gte("fechahoraIniEvent", ahora)
                );

                return collection.Find(filtro).ToList();
            }
            catch (Exception)
            {
                return new List<Evento>();
            }
        }

        // Cambia estadoevento a "inhabilitado" en vez de borrar el documento (borrado lógico).
        public bool DeshabilitarEvento(ObjectId id)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");
                var filtro = Builders<BsonDocument>.Filter.Eq("_id", id);
                var update  = Builders<BsonDocument>.Update.Set("estadoevento", "inhabilitado");
                var resultado = collection.UpdateOne(filtro, update);
                // ModifiedCount > 0 confirma que al menos un documento fue actualizado.
                return resultado.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        // Actualiza nombre, tipo y fechas de un evento existente; retorna true si tuvo efecto.
        public bool ActualizarEvento(string nombre, string tipo,
            DateTime fechaIni, DateTime fechaFin, ObjectId id)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");
                var filtro = Builders<BsonDocument>.Filter.Eq("_id", id);

                // Las fechas se convierten a string antes de guardar porque la BD las almacena como texto.
                var update = Builders<BsonDocument>.Update
                    .Set("nombreEvent",       nombre)
                    .Set("tipoevent",         tipo)
                    .Set("fechahoraIniEvent", fechaIni.ToString("yyyy-MM-dd HH:mm:ss"))
                    .Set("fechahoraFinEvent", fechaFin.ToString("yyyy-MM-dd HH:mm:ss"));

                var resultado = collection.UpdateOne(filtro, update);
                return resultado.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}
