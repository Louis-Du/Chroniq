using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace src.Modelo
{
    public class EventoModelo
    {
        public Evento ObtenerEventoPorId(string idEvento)
        {
            try
            {
                var database = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<Evento>("Eventos");

                var filtro = Builders<Evento>.Filter.Eq(e => e.Id, idEvento);
                return collection.Find(filtro).FirstOrDefault();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string GuardarEvento(string nombreEvent, string tipoEvent, string fechahoraIniEvent, string fechahoraFinEvent, string idLider)
        {
            try
            {
                var database = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<BsonDocument>("Eventos");

                // Verificar conflicto de horario:
                // Hay conflicto si existe algún evento cuyos rangos se solapan.
                var filtroConflicto = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Lt("fechahoraIniEvent", fechahoraFinEvent),
                    Builders<BsonDocument>.Filter.Gt("fechahoraFinEvent", fechahoraIniEvent)
                );

                if (collection.Find(filtroConflicto).Any())
                    return null;

                // Generar codigoEvent
                int codigoEvent = (int)collection.CountDocuments(new BsonDocument()) + 1;

                var documento = new BsonDocument
                {
                    { "codigoEvent",       codigoEvent },
                    { "nombreEvent",       nombreEvent },
                    { "tipoevent",         tipoEvent },
                    { "fechahoraIniEvent", fechahoraIniEvent },
                    { "fechahoraFinEvent", fechahoraFinEvent },
                    { "creadoPor",         new ObjectId(idLider) },
                    { "invitados",         new BsonArray() }
                };

                collection.InsertOne(documento);
                return documento["_id"].AsObjectId.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Obtiene todos los eventos cuya fecha de inicio es posterior a la fecha actual.
        /// Se usa para mostrar eventos futuros en HU-03: Consultar eventos.
        /// </summary>
        /// <param name="fechaActual">Fecha actual en formato "yyyy-MM-dd HH:mm:ss"</param>
        /// <returns>Lista de eventos futuros. Vacía si no hay eventos.</returns>
        public List<Evento> ObtenerEventos(string fechaActual)
        {
            try
            {
                // Obtener la base de datos desde la clase Conexion
                var database = Conexion.ObtenerBaseDatos();

                // Obtener la colección "Eventos" mapeada a la clase Evento
                var collection = database.GetCollection<Evento>("Eventos");

                // Construimos el filtro: buscamos eventos donde fechahoraIniEvent >= fechaActual
                var filtro = Builders<Evento>.Filter.Gte("fechahoraIniEvent", fechaActual);

                // Ejecutamos la consulta y la convertimos en lista
                var eventos = collection.Find(filtro).ToList();

                return eventos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // ver qué excepción está ocurriendo
                return new List<Evento>();
            }
        }

        public bool AgregarInvitado(string idEvento, string idInvitado, string fechahoraIniEvent, string fechahoraFinEvent)
        {
            try
            {
                var database = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<BsonDocument>("Eventos");

                if (string.IsNullOrWhiteSpace(idInvitado) || !ObjectId.TryParse(idInvitado, out ObjectId invitadoObjectId))
                    return false;


                // VALIDACIÓN 1: ¿El invitado ya está en este evento?
                if (string.IsNullOrWhiteSpace(idEvento) || !ObjectId.TryParse(idEvento, out ObjectId eventoObjectId))
                    return false;

                var filtroYaAgregado = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.Eq("_id", eventoObjectId),
                    Builders<BsonDocument>.Filter.AnyEq("invitados", invitadoObjectId)
                );


                if (collection.Find(filtroYaAgregado).Any())
                    return false;

                // VALIDACIÓN 2: ¿El invitado tiene otro evento en ese rango de horas?
                // Buscamos eventos donde el invitado ya esté Y los horarios se solapen.
                var filtroConflicto = Builders<BsonDocument>.Filter.And(
                    Builders<BsonDocument>.Filter.AnyEq("invitados", invitadoObjectId),
                    Builders<BsonDocument>.Filter.Lt("fechahoraIniEvent", fechahoraFinEvent),
                    Builders<BsonDocument>.Filter.Gt("fechahoraFinEvent", fechahoraIniEvent)
                );

                if (collection.Find(filtroConflicto).Any())
                    return false;

                // Las validaciones pasaron: agregar el ObjectId al array invitados
                var filtroEvento = Builders<BsonDocument>.Filter.Eq(
                    "_id", eventoObjectId);


                var actualizacion = Builders<BsonDocument>.Update.Push(
                    "invitados", invitadoObjectId);

                collection.UpdateOne(filtroEvento, actualizacion);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Evento> ObtenerEventosPorInvitado(string idUsuario)
        {
            var database = Conexion.ObtenerBaseDatos();
            var collection = database.GetCollection<Evento>("Eventos");

            string ahora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            if (string.IsNullOrWhiteSpace(idUsuario))
                return new List<Evento>();

            if (!ObjectId.TryParse(idUsuario, out ObjectId objectIdUsuario))
                return new List<Evento>();

            // Nota: en la BD el campo puede ser "estadoevento" o venir sin estado.
            // Para mantener el 10% funcional, aceptamos:
            //  - estadoevento == "habilitado"
            //  - o que no exista (se asume habilitado en la lógica actual)
            var filtroEstado = Builders<Evento>.Filter.Eq("estadoevento", "habilitado");
            var filtro = Builders<Evento>.Filter.And(
                Builders<Evento>.Filter.AnyEq("invitados", objectIdUsuario),
                filtroEstado,
                Builders<Evento>.Filter.Gte("fechahoraIniEvent", ahora)
            );

            return collection.Find(filtro).ToList();
        }

        public bool DeshabilitarEvento(ObjectId id)
        {
            try
            {
                var database = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<BsonDocument>("Eventos");

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
                var database = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<BsonDocument>("Eventos");

                //  Filtro por ID
                var filtro = Builders<BsonDocument>.Filter.Eq("_id", id);

                //  Campos a actualizar
                var update = Builders<BsonDocument>.Update
                    .Set("nombreEvent", nombre)
                    .Set("tipoevent", tipo)
                    .Set("fechahoraIniEvent", fechaIni)
                    .Set("fechahoraFinEvent", fechaFin);

                //  Ejecutar actualización
                var resultado = collection.UpdateOne(filtro, update);

                //  Si modificó al menos 1 documento
                return resultado.ModifiedCount > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}