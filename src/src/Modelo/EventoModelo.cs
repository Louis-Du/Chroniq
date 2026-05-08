using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace src.Modelo
{
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

        // Inserta un evento nuevo con estadoevento "habilitado" y retorna su _id; null si hay conflicto o error.
        public string GuardarEvento(string nombreEvent, string tipoEvent, string fechahoraIniEvent, string fechahoraFinEvent, string idLider)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");

                // Detecta solapamiento: hay conflicto si otro evento activo empieza antes de que este termine Y termina después de que este empiece.
                var filtroConflicto = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Ne("estadoevento", "inhabilitado"),
                    Builders<BsonDocument>.Filter.Lt("fechahoraIniEvent", fechahoraFinEvent),
                    Builders<BsonDocument>.Filter.Gt("fechahoraFinEvent", fechahoraIniEvent)
                );

                if (collection.Find(filtroConflicto).Any())
                    return null;

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
                    // CORRECCIÓN: se agrega el campo estadoevento al crear el evento.
                    // Sin este campo, ObtenerEventosPorInvitado no retorna el evento.
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

        // Retorna eventos futuros no deshabilitados; Ne("inhabilitado") incluye eventos con y sin el campo estadoevento.
        public List<Evento> ObtenerEventos(string fechaActual)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<Evento>("Eventos");

                // CORRECCIÓN: filtrar eventos deshabilitados del grid del líder.
                // Ne en vez de Eq("habilitado") para incluir también eventos sin el campo (datos anteriores a esta feature).
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

        public bool AgregarInvitado(string idEvento, string idInvitado, string fechahoraIniEvent, string fechahoraFinEvent)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");

                if (!ObjectId.TryParse(idInvitado, out ObjectId invitadoObjectId)) return false;
                if (!ObjectId.TryParse(idEvento, out ObjectId eventoObjectId)) return false;

                // Verifica que el invitado no esté ya en este evento.
                var filtroYaAgregado = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("_id", eventoObjectId),
                    Builders<BsonDocument>.Filter.AnyEq("invitados", invitadoObjectId)
                );
                if (collection.Find(filtroYaAgregado).Any()) return false;

                // Verifica que el invitado no tenga otro evento activo con horario solapado.
                var filtroConflicto = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.AnyEq("invitados", invitadoObjectId),
                    Builders<BsonDocument>.Filter.Ne("estadoevento", "inhabilitado"),
                    Builders<BsonDocument>.Filter.Lt("fechahoraIniEvent", fechahoraFinEvent),
                    Builders<BsonDocument>.Filter.Gt("fechahoraFinEvent", fechahoraIniEvent)
                );
                if (collection.Find(filtroConflicto).Any()) return false;

                // $push agrega el ObjectId al array sin reemplazar los elementos existentes.
                var filtroEvento = Builders<BsonDocument>.Filter.Eq("_id", eventoObjectId);
                var actualizacion = Builders<BsonDocument>.Update.Push("invitados", invitadoObjectId);
                collection.UpdateOne(filtroEvento, actualizacion);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Retorna eventos futuros donde el usuario está inscrito y el evento no está deshabilitado.
        public List<Evento> ObtenerEventosPorInvitado(string idUsuario)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<Evento>("Eventos");
                string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (!ObjectId.TryParse(idUsuario, out ObjectId objectIdUsuario))
                    return new List<Evento>();

                // CORRECCIÓN: Ne("inhabilitado") en lugar de Eq("habilitado") para incluir
                // eventos sin el campo estadoevento (datos anteriores a esta funcionalidad).
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

        // $set actualiza estadoevento a "inhabilitado"; ModifiedCount > 0 confirma que el documento fue modificado.
        public bool DeshabilitarEvento(ObjectId id)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");
                var filtro = Builders<BsonDocument>.Filter.Eq("_id", id);
                var update = Builders<BsonDocument>.Update.Set("estadoevento", "inhabilitado");
                var resultado = collection.UpdateOne(filtro, update);
                return resultado.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }

        public bool ActualizarEvento(string nombre, string tipo, DateTime fechaIni, DateTime fechaFin, ObjectId id)
        {
            try
            {
                var collection = Conexion.ObtenerBaseDatos().GetCollection<BsonDocument>("Eventos");
                var filtro = Builders<BsonDocument>.Filter.Eq("_id", id);

                // Las fechas se convierten a string antes de guardar; la BD las almacena como texto "yyyy-MM-dd HH:mm:ss".
                var update = Builders<BsonDocument>.Update
                    .Set("nombreEvent", nombre)
                    .Set("tipoevent", tipo)
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