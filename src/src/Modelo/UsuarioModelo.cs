using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace src.Modelo
{
    public class UsuarioModelo
    {
        private readonly IMongoCollection<Usuario> _coleccionUsuarios;

        public UsuarioModelo()
        {
            _coleccionUsuarios = Conexion.ObtenerBaseDatos().GetCollection<Usuario>("Usuarios");
        }

        // Autentica comparando cédula y contraseña; retorna null si no existe coincidencia.
        public Usuario BuscarPorCredenciales(int numeroCedula, string passwordUser)
        {
            var filtro = Builders<Usuario>.Filter.And(
                Builders<Usuario>.Filter.Eq(u => u.NumeroCedula, numeroCedula),
                Builders<Usuario>.Filter.Eq(u => u.PasswordUser, passwordUser)
            );
            return _coleccionUsuarios.Find(filtro).FirstOrDefault();
        }

        // Retorna solo los usuarios con tipoUser "Invitado"; excluye líderes.
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

        // Consulta usuarios cuyo Id esté dentro de la lista; usado para mostrar inscritos de un evento.
        public List<Usuario> ObtenerInvitadosInscriptos(List<string> idsInvitados)
        {
            try
            {
                if (idsInvitados == null || idsInvitados.Count == 0)
                    return new List<Usuario>();

                var filtro = Builders<Usuario>.Filter.In(u => u.Id, idsInvitados);
                return _coleccionUsuarios.Find(filtro).ToList();
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        public bool GuardarInvitado(string nombre, string genero, string tipo, string email,
            long telefono, int edad, int cedula, string password)
        {
            try
            {
                var database = Conexion.ObtenerBaseDatos();
                var collection = database.GetCollection<BsonDocument>("Usuarios");

                // CORRECCIÓN: evita cédulas duplicadas; retorna false si ya existe un usuario con esa cédula.
                var filtroDuplicado = Builders<BsonDocument>.Filter.Eq("numeroCedula", cedula);
                if (collection.Find(filtroDuplicado).Any())
                    return false;

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