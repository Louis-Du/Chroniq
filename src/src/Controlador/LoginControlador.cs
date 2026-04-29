// ============================================================
//  CAPA: CONTROLADOR  →  Archivo: LoginControlador.cs
// ============================================================
//  HU-01: Iniciar sesión
//  HU-08: Cerrar sesión (parcial - la Vista maneja el formulario)
//
//  Cambio respecto a la versión anterior:
//  FormLider ahora recibe dos parámetros: NombreUser e Id.
//  Se actualiza la llamada en AbrirFormulario para pasar ambos.
// ============================================================

using System;
using System.Windows.Forms;
using src.Modelo;
using src.Vista;

namespace src.Controlador
{
    public class LoginControlador
    {
        private readonly UsuarioModelo _usuarioModelo;

        public LoginControlador()
        {
            _usuarioModelo = new UsuarioModelo();
        }

        /// <summary>
        /// Valida las credenciales y abre el formulario según el rol. (HU-01)
        ///
        /// Como lo llama la Vista (FormLogin):
        ///   controlador.IniciarSesion(txtNomuser.Text, txtContraseña.Text, this);
        /// </summary>
        public void IniciarSesion(int numeroCedula, string passwordUser, Form formularioActual)
        {
            try
            {
                // PASO 1: Validar campos vacíos.
                if (numeroCedula <= 0 || string.IsNullOrWhiteSpace(passwordUser))
                {
                    MessageBox.Show("Por favor, ingresa el nombre de usuario y la contraseña.",
                        "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // PASO 2: Consultar el Modelo.
                // Llamada a: Modelo/UsuarioModelo.cs → BuscarPorCredenciales(...)
                Usuario usuarioEncontrado = _usuarioModelo.BuscarPorCredenciales(numeroCedula, passwordUser);

            // PASO 3: Lógica del negocio sobre el resultado.
            if (usuarioEncontrado == null)
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta de nuevo.",
                    "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usuarioEncontrado.TipoUser == "Lider")
            {
                // Pasamos NombreUser para la bienvenida e Id para las operaciones futuras.
                // El Id es el _id de MongoDB que necesitan HU-02 (creadoPor) y HU-05.
                AbrirFormulario(
                    new FormLider(usuarioEncontrado.NombreUser, usuarioEncontrado.Id),
                    formularioActual);
            }
            else if (usuarioEncontrado.TipoUser == "Invitado")
            {
                AbrirFormulario(
                    new FormInvitado(usuarioEncontrado.NombreUser),
                    formularioActual);
            }
            else
            {
                MessageBox.Show(
                    $"El tipo de usuario '{usuarioEncontrado.TipoUser}' no está configurado en el sistema.",
                    "Error de configuración", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al iniciar sesión:\n\n{ex.Message}\n\nDetalles:\n{ex.InnerException?.Message}",
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Abre el formulario destino y oculta el formulario actual.
        /// Privado: solo lo usa este Controlador internamente.
        /// </summary>
        private void AbrirFormulario(Form formularioDestino, Form formularioActual)
        {
            formularioDestino.Show();
            formularioActual.Hide();
        }
    }
}
