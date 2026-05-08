using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace src.Modelo
{
    // Clase que representa un evento en la base de datos MongoDB.
    // Cada propiedad con [BsonElement] se mapea a un campo del documento.
    public class Evento
    {
        // _id de MongoDB; se representa como string gracias a BsonRepresentation.
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // Código numérico incremental asignado al crear el evento.
        [BsonElement("codigoEvent")]
        public int CodigoEvent { get; set; }

        [BsonElement("nombreEvent")]
        public string NombreEvent { get; set; }

        // Guarda el _id del líder que creó el evento (referencia a Usuarios).
        [BsonElement("creadoPor")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CreadoPor { get; set; }

        [BsonElement("tipoevent")]
        public string TipoEvent { get; set; }

        // Fechas guardadas como texto con formato "yyyy-MM-dd HH:mm:ss".
        [BsonElement("fechahoraIniEvent")]
        public string FechahoraIniEvent { get; set; }

        [BsonElement("fechahoraFinEvent")]
        public string FechahoraFinEvent { get; set; }

        // Estado del evento: "habilitado" o "inhabilitado".
        [BsonElement("estadoevento")]
        public string EstadoEvento { get; set; }

        // Lista de _id de invitados inscritos. BsonRepresentation permite
        // convertir automáticamente ObjectId ↔ string en cada elemento del array.
        [BsonElement("invitados")]
        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> Invitados { get; set; } = new List<string>();
    }
}
