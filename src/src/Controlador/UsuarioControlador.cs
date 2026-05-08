using MongoDB.Bson;
using src.Modelo;
using src.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace src.Controlador
{
    internal class UsuarioControlador
    {
        private readonly UsuarioModelo _usuarioModelo;

        public UsuarioControlador()
        {
            _usuarioModelo = new UsuarioModelo();
        }

        public bool CrearNuevoInvitado(string nombre, string genero, string email, long telefono, int edad, int cedula, string password)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre es obligatorio.",
                        "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(genero))
                {
                    MessageBox.Show("El género es obligatorio.",
                        "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("El email es obligatorio.",
                        "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (!email.Contains("@"))
                {
                    MessageBox.Show("El email ingresado no es válido.",
                        "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("La contraseña es obligatoria.",
                        "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (cedula.ToString().Length < 4)
                {
                    MessageBox.Show("Número de cédula muy corto.",
                        "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (telefono.ToString().Length < 10)
                {
                    MessageBox.Show("Número de teléfono muy corto.",
                        "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool guardado = _usuarioModelo.GuardarInvitado(nombre, genero, "Invitado", email, telefono, edad, cedula, password);

                if (guardado)
                {
                    MessageBox.Show($"El usuario '{nombre}' fue creado correctamente.",
                        "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }   
    }
}
