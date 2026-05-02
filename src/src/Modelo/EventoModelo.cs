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
        public bool GuardarEvento(string nombre, string tipo, string fechaIni, string fechaFin, string idLider)
        {
            try
            {
                //  Obtener la base de datos desde la clase Conexion
                var database = Conexion.ObtenerBaseDatos();

                //  Obtener la colección "Eventos"
                var collection = database.GetCollection<BsonDocument>("Eventos");

                //  Crear el documento del evento
                var documento = new BsonDocument
                {
                    { "nombre", nombre },
                    { "tipo", tipo },
                    { "fechaInicio", fechaIni },
                    { "fechaFin", fechaFin },
                    { "creadoPor", new ObjectId(idLider) }, // relación con usuario
                    { "invitados", new BsonArray() } // lista vacía
                };

                // Insertar el documento
                collection.InsertOne(documento);

                //  Si todo sale bien, retorna true
                return true;
            }
            catch (Exception)
            {
                //  Si ocurre cualquier error, retorna false
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