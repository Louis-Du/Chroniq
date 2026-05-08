using src.Modelo;
using System;
using System.Windows.Forms;

namespace src.Controlador
{
    // Controlador de operaciones sobre usuarios (creación de invitados).
    // Es public para que FormCrearInvitado (Vista) pueda instanciarlo.
    public class UsuarioControlador
    {
        private readonly UsuarioModelo _usuarioModelo;

        public UsuarioControlador()
        {
            _usuarioModelo = new UsuarioModelo();
        }

        // Valida los campos del formulario y, si son correctos, guarda el nuevo invitado en la BD.
        public bool CrearNuevoInvitado(string nombre, string genero, string email,
            long telefono, int edad, int cedula, string password)
        {
            try
            {
                // Validamos campo por campo y mostramos mensaje específico en cada caso.
                if (string.IsNullOrWhiteSpace(nombre))
                {
                    MessageBox.Show("El nombre es obligatorio.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(genero))
                {
                    MessageBox.Show("El género es obligatorio.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("El email es obligatorio.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Validación básica de email: debe contener "@".
                if (!email.Contains("@"))
                {
                    MessageBox.Show("El email ingresado no es válido.", "Campo incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("La contraseña es obligatoria.", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // Cédula con menos de 4 dígitos probablemente es un error de digitación.
                if (cedula.ToString().Length < 4)
                {
                    MessageBox.Show("Número de cédula muy corto.", "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                if (telefono.ToString().Length < 10)
                {
                    MessageBox.Show("Número de teléfono muy corto.", "Longitud inadecuada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                // GuardarInvitado retorna false si ya existe un usuario con esa cédula.
                bool guardado = _usuarioModelo.GuardarInvitado(
                    nombre, genero, "Invitado", email, telefono, edad, cedula, password);

                if (guardado)
                {
                    MessageBox.Show($"El usuario '{nombre}' fue creado correctamente.",
                        "Usuario creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }

                MessageBox.Show("No se pudo crear el usuario. La cédula ya está registrada.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
