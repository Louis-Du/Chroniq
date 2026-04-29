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
    }
}