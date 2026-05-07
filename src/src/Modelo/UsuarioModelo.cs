using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace src.Modelo
{
    // ==========================================================
    //  PARTE 1: ENTIDAD USUARIO
    //  Representa un documento de la colección "Usuarios" en MongoDB.
    //  Los atributos [BsonElement] mapean el nombre del campo
    //  en MongoDB con la propiedad de C#.
    // ==========================================================
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

    public class UsuarioModelo
    {
        // Referencia a la colección "Usuarios" en MongoDB.
        // Se obtiene usando Conexion.ObtenerBaseDatos() que está
        // en el mismo paquete Modelo.
        private readonly IMongoCollection<Usuario> _coleccionUsuarios;

        /// <summary>
        /// Constructor: obtiene la conexión y apunta a la colección "Usuarios".
        /// Se ejecuta cuando el Controlador hace: new UsuarioModelo()
        /// </summary>
        public UsuarioModelo()
        {
            IMongoDatabase baseDatos = Conexion.ObtenerBaseDatos();
            _coleccionUsuarios = baseDatos.GetCollection<Usuario>("Usuarios");
        }

        /// <summary>
        /// Busca un usuario en la BD que coincida con el nombre y contraseña.
        ///
        /// IMPORTANTE: Este método SOLO busca y devuelve el dato.
        /// No decide qué hacer si el usuario es Líder o Invitado;
        /// esa decisión le corresponde al Controlador.
        ///
        /// ¿Cómo se llama desde el Controlador?
        ///   UsuarioModelo modelo = new UsuarioModelo();
        ///   Usuario usuario = modelo.BuscarPorCredenciales("Miguel David", "lider1");
        ///
        /// Retorna: el objeto Usuario si las credenciales son correctas,
        ///          null si no existe ningún usuario con esos datos.
        /// </summary>
        /// <param name="numeroCedula">Nombre de usuario ingresado en el formulario.</param>
        /// <param name="passwordUser">Contraseña ingresada en el formulario.</param>
        public Usuario BuscarPorCredenciales(int numeroCedula, string passwordUser)
        {
            // Construimos el filtro: buscamos donde numeroCedula Y passwordUser coincidan.
            var filtro = Builders<Usuario>.Filter.And(
                Builders<Usuario>.Filter.Eq(u => u.NumeroCedula, numeroCedula),
                Builders<Usuario>.Filter.Eq(u => u.PasswordUser, passwordUser)
            );

            // Ejecutamos la consulta y devolvemos el primer resultado (o null).
            return _coleccionUsuarios.Find(filtro).FirstOrDefault();
        }

        public List<Usuario> ObtenerInvitados()
        {
            try
            {
                var filtro = Builders<Usuario>.Filter.Eq(u => u.TipoUser, "Invitado");
                return _coleccionUsuarios.Find(filtro).ToList();
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        public List<Usuario> ObtenerInvitadosInscriptos(List<string> idsInvitados)
        {
            try
            {
                if (idsInvitados == null || idsInvitados.Count == 0)
                    return new List<Usuario>();

                // Busca todos los usuarios cuyo Id esté en la lista
                var filtro = Builders<Usuario>.Filter.In(u => u.Id, idsInvitados);
                return _coleccionUsuarios.Find(filtro).ToList();
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }
    }
}