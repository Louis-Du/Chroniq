using MaterialSkin;
using src.Controlador;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    public partial class FormLogin : BaseMaterialForm
    {
        private readonly LoginControlador _loginControlador;

        public FormLogin()
        {
            InitializeComponent();
            _loginControlador = new LoginControlador();
        }



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
            // CORRECCIÓN: TryParse en lugar de Parse para evitar crash si el campo está vacío o tiene texto pegado.
            if (!int.TryParse(txtNumeroCedula.Text.Trim(), out int numeroCedula))
            {
                MessageBox.Show("Ingresa un número de cédula válido.",
                    "Campo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passwordIngresada = txtContraseña.Text.Trim();
            _loginControlador.IniciarSesion(numeroCedula, passwordIngresada, this);
        }

        // Bloquea caracteres no numéricos en el campo de cédula a nivel de teclado.
        private void txtNumeroCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números en el campo de ID de usuario.", "APLICACION");
            }
        }
    }
}