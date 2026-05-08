// ============================================================
//  CAPA: MODELO  →  Archivo: Conexion.cs
// ============================================================
//  RESPONSABILIDAD ÚNICA: Este archivo SOLO gestiona la
//  conexión a MongoDB. No tiene lógica de negocio ni UI.
// ============================================================

using MongoDB.Driver;

namespace src.Modelo
{
    // Clase estática: no se instancia, se llama directamente con Conexion.ObtenerBaseDatos().
    public static class Conexion
    {
        // Cambia estos valores si MongoDB corre en otro host o puerto.
        private const string CADENA_CONEXION   = "mongodb://localhost:27017";
        private const string NOMBRE_BASE_DATOS = "BDgestorEventos";

        // Guarda la instancia de BD; se crea solo la primera vez (patrón Singleton).
        private static IMongoDatabase _baseDatos = null;

        /// <summary>
        /// Retorna la instancia de la base de datos MongoDB.
        /// Si aún no existe conexión, la crea; de lo contrario reutiliza la misma.
        /// </summary>
        public static IMongoDatabase ObtenerBaseDatos()
        {
            // Solo conectamos si aún no hay instancia; evita abrir múltiples conexiones.
            if (_baseDatos == null)
            {
                MongoClient cliente = new MongoClient(CADENA_CONEXION);
                _baseDatos = cliente.GetDatabase(NOMBRE_BASE_DATOS);
            }

            return _baseDatos;
        }
    }
}
