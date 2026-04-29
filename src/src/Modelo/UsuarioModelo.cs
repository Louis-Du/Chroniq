// ============================================================
//  CAPA: MODELO  →  Archivo: UsuarioModelo.cs
// ============================================================
//  RESPONSABILIDAD: Este archivo hace DOS cosas relacionadas
//  con los datos del usuario:
//
//  1. Define la ENTIDAD (clase Usuario): representa la
//     estructura de un documento de la colección "Usuarios"
//     en MongoDB. Es como el "molde" del dato.
//
//  2. Contiene el ACCESO A DATOS: el método que va a la BD
//     y busca un usuario. NO decide qué hacer con el resultado,
//     solo busca y devuelve el dato (o null si no existe).
//     La decisión la toma el Controlador.
//
//  ¿Qué NO hace este archivo?
//  - No abre formularios (eso es la Vista).
//  - No valida si el usuario es líder o invitado (eso es
//    el Controlador, que aplica la lógica del negocio).
// ============================================================

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

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

        // El campo en MongoDB se llama "nombreUser"
        [BsonElement("nombreUser")]
        public string NombreUser { get; set; }

        // El campo en MongoDB se llama "passwordUser"
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


    // ==========================================================
    //  PARTE 2: ACCESO A DATOS - UsuarioModelo
    //  Aquí viven los métodos que consultan la colección
    //  "Usuarios" en MongoDB.
    //
    //  ¿Quién llama a esta clase?
    //  → El CONTROLADOR (LoginControlador) la instancia y
    //    llama a sus métodos.
    //  La Vista nunca toca esta clase directamente.
    // ==========================================================
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
            // Llamamos a Conexion (mismo Modelo) para obtener la BD.
            // El Controlador no necesita saber nada sobre MongoDB;
            // esa responsabilidad queda encapsulada aquí.
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
        /// <param name="nombreUser">Nombre de usuario ingresado en el formulario.</param>
        /// <param name="passwordUser">Contraseña ingresada en el formulario.</param>
        public Usuario BuscarPorCredenciales(string nombreUser, string passwordUser)
        {
            // Construimos el filtro: buscamos donde nombreUser Y passwordUser coincidan.
            var filtro = Builders<Usuario>.Filter.And(
                Builders<Usuario>.Filter.Eq("nombreUser", nombreUser),
                Builders<Usuario>.Filter.Eq("passwordUser", passwordUser)
            );

            // Ejecutamos la consulta y devolvemos el primer resultado (o null).
            return _coleccionUsuarios.Find(filtro).FirstOrDefault();
        }
    }
}