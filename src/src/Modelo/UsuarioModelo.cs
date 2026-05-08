using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace src.Modelo
{
    // Capa de acceso a datos para la colección "Usuarios" de MongoDB.
    public class UsuarioModelo
    {
        // Campo privado que guarda referencia a la colección; se inicializa una sola vez en el constructor.
        private readonly IMongoCollection<Usuario> _coleccionUsuarios;

        public UsuarioModelo()
        {
            _coleccionUsuarios = Conexion.ObtenerBaseDatos().GetCollection<Usuario>("Usuarios");
        }

        // Busca un usuario con la cédula y contraseña dadas; retorna null si no coincide ninguno.
        public Usuario BuscarPorCredenciales(int numeroCedula, string passwordUser)
        {
            var filtro = Builders<Usuario>.Filter.And(
                Builders<Usuario>.Filter.Eq(u => u.NumeroCedula, numeroCedula),
                Builders<Usuario>.Filter.Eq(u => u.PasswordUser, passwordUser)
            );
            return _coleccionUsuarios.Find(filtro).FirstOrDefault();
        }

        // Retorna solo los usuarios cuyo tipoUser sea "Invitado" (excluye líderes).
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

        // Retorna solo los usuarios cuyos Id estén en la lista dada; útil para mostrar inscritos de un evento.
        public List<Usuario> ObtenerInvitadosInscriptos(List<string> idsInvitados)
        {
            try
            {
                if (idsInvitados == null || idsInvitados.Count == 0)
                    return new List<Usuario>();

                // Filter.In busca todos los documentos cuyo Id esté dentro de la lista.
                var filtro = Builders<Usuario>.Filter.In(u => u.Id, idsInvitados);
                return _coleccionUsuarios.Find(filtro).ToList();
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        // Inserta un nuevo invitado; retorna false si ya existe un usuario con esa cédula.
        public bool GuardarInvitado(string nombre, string genero, string tipo, string email,
            long telefono, int edad, int cedula, string password)
        {
            try
            {
                var database   = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<BsonDocument>("Usuarios");

                // Verificamos duplicado por cédula antes de insertar.
                var filtroDuplicado = Builders<BsonDocument>.Filter.Eq("numeroCedula", cedula);
                if (collection.Find(filtroDuplicado).Any())
                    return false; // Cédula ya registrada.

                var documento = new BsonDocument
                {
                    { "nombreUser",   nombre },
                    { "generoUser",   genero },
                    { "tipoUser",     tipo },
                    { "emailUser",    email },
                    { "telefonoUser", telefono },
                    { "edadUser",     edad },
                    { "numeroCedula", cedula },
                    { "passwordUser", password }
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
