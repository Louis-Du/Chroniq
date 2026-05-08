using MaterialSkin;
using src.Controlador;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    // Formulario de inicio de sesión; es el primer formulario que se muestra al abrir la app.
    public partial class FormLogin : BaseMaterialForm
    {
        private readonly LoginControlador _loginControlador;

        public FormLogin()
        {
            InitializeComponent();
            _loginControlador = new LoginControlador();
        }

        // Cierra la aplicación completa tras confirmación del usuario.
        private void btnSalirlogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Confirmar salida",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIniciarsesion_Click_1(object sender, EventArgs e)
        {
            // TryParse evita que la app crashee si el campo está vacío o contiene letras.
            if (!int.TryParse(txtNumeroCedula.Text.Trim(), out int numeroCedula))
            {
                MessageBox.Show("Ingresa un número de cédula válido.",
                    "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordIngresada = txtContraseña.Text.Trim();

            // Delegamos la autenticación al controlador; este formulario no sabe cómo validar.
            _loginControlador.IniciarSesion(numeroCedula, passwordIngresada, this);
        }

        // Bloquea en tiempo real la entrada de caracteres no numéricos en el campo de cédula.
        private void txtNumeroCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // e.Handled = true cancela el carácter antes de que aparezca.
                MessageBox.Show("Solo se permiten números en el campo de ID de usuario.", "APLICACION");
            }
        }
    }
}
