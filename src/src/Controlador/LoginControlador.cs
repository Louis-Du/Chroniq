using System;
using System.Windows.Forms;
using src.Modelo;
using src.Vista;

namespace src.Controlador
{
    // Controlador que maneja la lógica de autenticación de usuarios.
    public class LoginControlador
    {
        // Usamos readonly para que el modelo no pueda ser reasignado después del constructor.
        private readonly UsuarioModelo _usuarioModelo;

        public LoginControlador()
        {
            _usuarioModelo = new UsuarioModelo();
        }

        /// <summary>
        /// Valida las credenciales y abre el formulario según el rol del usuario.
        ///
        /// La Vista lo llama así:
        ///   _loginControlador.IniciarSesion(numeroCedula, txtContraseña.Text, this);
        /// </summary>
        public void IniciarSesion(int numeroCedula, string passwordUser, Form formularioActual)
        {
            try
            {
                // Validamos que los campos no estén vacíos antes de consultar la BD.
                if (numeroCedula <= 0 || string.IsNullOrWhiteSpace(passwordUser))
                {
                    MessageBox.Show("Por favor, ingresa el número de cédula y la contraseña.",
                        "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuarioEncontrado = _usuarioModelo.BuscarPorCredenciales(numeroCedula, passwordUser);

                // Si no existe el usuario, mostramos error y detenemos el flujo.
                if (usuarioEncontrado == null)
                {
                    MessageBox.Show("Cédula o contraseña incorrectos. Intenta de nuevo.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Redirigimos al formulario correspondiente según el tipo de usuario.
                if (usuarioEncontrado.TipoUser == "Lider")
                {
                    AbrirFormulario(
                        new FormLider(usuarioEncontrado.NombreUser, usuarioEncontrado.Id),
                        formularioActual);
                }
                else if (usuarioEncontrado.TipoUser == "Invitado")
                {
                    AbrirFormulario(
                        new FormInvitado(usuarioEncontrado.NombreUser, usuarioEncontrado.Id),
                        formularioActual);
                }
                else
                {
                    // Tipo desconocido: puede ocurrir si se agrega un nuevo rol sin actualizar este código.
                    MessageBox.Show(
                        $"El tipo de usuario '{usuarioEncontrado.TipoUser}' no está configurado en el sistema.",
                        "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Capturamos excepciones de conexión a MongoDB u otros errores inesperados.
                MessageBox.Show(
                    $"Error al iniciar sesión:\n\n{ex.Message}\n\nDetalles:\n{ex.InnerException?.Message}",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Muestra el formulario destino y oculta el formulario de login.
        private void AbrirFormulario(Form formularioDestino, Form formularioActual)
        {
            formularioDestino.Show();
            formularioActual.Hide();
        }
    }
}
