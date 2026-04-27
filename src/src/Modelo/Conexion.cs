// ============================================================
//  CAPA: MODELO  →  Archivo: Conexion.cs
// ============================================================
//  RESPONSABILIDAD ÚNICA: Este archivo SOLO sabe cómo
//  conectarse a MongoDB. No tiene lógica de negocio
//  ni consultas de datos. Solo entrega la base de datos.
//
//  ¿Por qué está en el Modelo?
//  La conexión ES parte del modelo: es la infraestructura
//  que permite acceder a los datos. No es lógica de negocio
//  (eso va en el Controlador) ni interfaz (eso va en la Vista).
// ============================================================

using MongoDB.Driver;

namespace src.Modelo
{
    /// <summary>
    /// Clase estática que gestiona la conexión a MongoDB.
    /// Se llama desde las clases del Modelo que necesiten
    /// acceder a la base de datos (ej: UsuarioModelo).
    /// </summary>
    public static class Conexion
    {
        // ----------------------------------------------------------
        //  Configuración de la conexión
        //  Cambia estos valores según tu entorno local o servidor.
        // ----------------------------------------------------------
        private const string CADENA_CONEXION = "mongodb://localhost:27017";
        private const string NOMBRE_BASE_DATOS = "BDgestorEventos";

        // Campo privado que guarda la instancia única del cliente MongoDB.
        // Es "lazy": se crea solo la primera vez que alguien llama a ObtenerBaseDatos().
        private static IMongoDatabase _baseDatos = null;

        /// <summary>
        /// Devuelve la instancia de la base de datos MongoDB.
        /// Si aún no se ha conectado, abre la conexión primero.
        ///
        /// ¿Cómo se llama desde otro archivo?
        ///   IMongoDatabase db = Conexion.ObtenerBaseDatos();
        ///   (Desde UsuarioModelo, por ejemplo)
        /// </summary>
        public static IMongoDatabase ObtenerBaseDatos()
        {
            // Solo creamos el cliente la primera vez (patrón Singleton simple).
            if (_baseDatos == null)
            {
                MongoClient cliente = new MongoClient(CADENA_CONEXION);
                _baseDatos = cliente.GetDatabase(NOMBRE_BASE_DATOS);
            }

            return _baseDatos;
        }
    }
}