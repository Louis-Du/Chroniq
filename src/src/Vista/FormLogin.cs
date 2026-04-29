
using System;
using System.Windows.Forms;
using MaterialSkin;
using src.Controlador;

namespace src.Vista
{
    public partial class FormLogin : BaseMaterialForm
    {

        private readonly LoginControlador _loginControlador;

        /// <summary>
        /// Constructor del formulario de login.
        /// Aquí inicializamos el controlador que vamos a usar.
        /// </summary>
        public FormLogin()
        {
            InitializeComponent(); 
            _loginControlador = new LoginControlador();
        }

        private void swtOscuro_CheckedChanged(object sender, EventArgs e)
        {
            AlternarTema(); // Llama al método de la clase base (Vista/BaseMaterialForm.cs)
        }

        // -------------------------------------------------------
        //  EVENTO: Clic en el botón "Salir".
        //  Confirma y cierra la aplicación.
        //  Lógica de UI pura → queda en la Vista.
        // -------------------------------------------------------
        private void btnSalirlogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Desea salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIniciarsesion_Click_1(object sender, EventArgs e)
        {
            // PASO 1: Leemos los valores el formulario (solo la Vista sabe dónde están).
            int numeroCedula = int.Parse(txtNumeroCedula.Text.Trim());
            string passwordIngresada = txtContraseña.Text.Trim();

            // PASO 2: Delegamos la lógica al Controlador.
            // Llamada a: Controlador/LoginControlador.cs → método IniciarSesion(...)
            // El Controlador validará, consultará el Modelo y abrirá el formulario correcto.
            _loginControlador.IniciarSesion(numeroCedula, passwordIngresada, this);
        }

        private void txtNumeroCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingresen caracteres no numéricos
                MessageBox.Show("Solo se permiten números en el campo de ID de usuario.", "APLICACION");
            }
        }
    }
}