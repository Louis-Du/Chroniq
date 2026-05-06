using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace src.Modelo
{
    public class Evento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("codigoEvent")]
        public int CodigoEvent { get; set; }

        [BsonElement("nombreEvent")]
        public string NombreEvent { get; set; }

        [BsonElement("creadoPor")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CreadoPor { get; set; }

        [BsonElement("tipoevent")]
        public string TipoEvent { get; set; }

        [BsonElement("fechahoraIniEvent")]
        public string FechahoraIniEvent { get; set; }

        [BsonElement("fechahoraFinEvent")]
        public string FechahoraFinEvent { get; set; }

        // CORRECCIÓN: agregar [BsonRepresentation(BsonType.ObjectId)] para que
        // el driver de MongoDB pueda convertir ObjectId ↔ string en cada elemento.
        // Sin este atributo lanza: "Cannot deserialize a 'String' from BsonType 'ObjectId'"
        [BsonElement("invitados")]
        [BsonRepresentation(BsonType.ObjectId)]
        public List<string> Invitados { get; set; } = new List<string>();
    }
}