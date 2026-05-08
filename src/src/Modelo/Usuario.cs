using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace src.Modelo
{
    public class Usuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombreUser")]
        public string NombreUser { get; set; }

        [BsonElement("passwordUser")]
        public string PasswordUser { get; set; }

        // El campo en MongoDB se llama "tipoUser" → "Lider" o "Invitado"
        [BsonElement("tipoUser")]
        public string TipoUser { get; set; }

        [BsonElement("generoUser")]
        public string GeneroUser { get; set; }

        [BsonElement("emailUser")]
        public string EmailUser { get; set; }

        [BsonElement("telefonoUser")]
        public long TelefonoUser { get; set; }

        [BsonElement("edadUser")]
        public int EdadUser { get; set; }

        [BsonElement("numeroCedula")]
        public int NumeroCedula { get; set; }
    }
}