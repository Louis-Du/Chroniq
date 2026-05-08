using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace src.Modelo
{
    // Clase que representa un usuario (Lider o Invitado) en la colección "Usuarios".
    public class Usuario
    {
        // _id de MongoDB, mapeado a string para facilitar su uso en C#.
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("nombreUser")]
        public string NombreUser { get; set; }

        [BsonElement("passwordUser")]
        public string PasswordUser { get; set; }

        // Rol del usuario en el sistema: "Lider" o "Invitado".
        [BsonElement("tipoUser")]
        public string TipoUser { get; set; }

        [BsonElement("generoUser")]
        public string GeneroUser { get; set; }

        [BsonElement("emailUser")]
        public string EmailUser { get; set; }

        // Se usa long para soportar números de teléfono de 10+ dígitos.
        [BsonElement("telefonoUser")]
        public long TelefonoUser { get; set; }

        [BsonElement("edadUser")]
        public int EdadUser { get; set; }

        // Cédula usada también como identificador para el login.
        [BsonElement("numeroCedula")]
        public int NumeroCedula { get; set; }
    }
}
