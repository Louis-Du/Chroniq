
using System;
using System.Windows.Forms;
using MaterialSkin;
using src.Controlador; // Necesitamos LoginControlador para delegarle la lógica

namespace src.Vista
{
    public partial class FormLogin : BaseMaterialForm
    {
        // -------------------------------------------------------
        //  La Vista tiene una referencia al Controlador.
        //  El Controlador se crea cuando se abre el formulario.
        //  La Vista NUNCA crea instancias del Modelo directamente.
        // -------------------------------------------------------
        private readonly LoginControlador _loginControlador;

        /// <summary>
        /// Constructor del formulario de login.
        /// Aquí inicializamos el controlador que vamos a usar.
        /// </summary>
        public FormLogin()
        {
            InitializeComponent(); // Inicializa los controles diseñados visualmente

            // Instanciamos el Controlador una sola vez.
            // El Controlador internamente prepara el Modelo.
            // La Vista no sabe (ni necesita saber) qué hace el Controlador internamente.
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
            // PASO 1: Leemos los valores del formulario (solo la Vista sabe dónde están).
            string nombreIngresado = txtNomuser.Text.Trim();
            string passwordIngresada = txtContraseña.Text.Trim();

            // PASO 2: Delegamos la lógica al Controlador.
            // Llamada a: Controlador/LoginControlador.cs → método IniciarSesion(...)
            // El Controlador validará, consultará el Modelo y abrirá el formulario correcto.
            _loginControlador.IniciarSesion(nombreIngresado, passwordIngresada, this);
        }
    }
}