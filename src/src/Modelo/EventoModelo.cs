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

                // Si se especificó un estado de evento, lo añadimos al filtro
             
                    filtro = Builders<Evento>.Filter.And(filtro,
                        Builders<Evento>.Filter.Eq("estadoevento", "habilitado"));

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