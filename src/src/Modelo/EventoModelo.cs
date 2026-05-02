using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace src.Modelo
{
    public class EventoModelo
    {
        public bool GuardarEvento(string nombreEvent, string tipoEvent, string fechahoraIniEvent, string fechahoraFinEvent, string idLider)
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
                    return false;

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
                return true;
            }
            catch (Exception)
            {
                return false;
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
                // Si ocurre un error, retornamos una lista vacía
                return new List<Evento>();
            }
        }
    }
}