using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace src.Modelo
{
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

        public bool GuardarInvitado(string nombre, string genero, string tipo, string email, long telefono, int edad, int cedula, string password)
        {
            try
            {
                var database = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<BsonDocument>("Usuarios");

                var documento = new BsonDocument
                {
                    { "nombreUser",       nombre },
                    { "generoUser",       genero },
                    { "tipoUser",         tipo },
                    { "emailUser", email },
                    { "telefonoUser", telefono },
                    { "edadUser", edad },
                    { "numeroCedula",         cedula },
                    {"passwordUser", password }
                };

                collection.InsertOne(documento);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}