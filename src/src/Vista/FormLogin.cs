// ============================================================
//  CAPA: VISTA  →  Archivo: FormLogin.cs
// ============================================================
//  RESPONSABILIDAD: Este archivo SOLO maneja lo visual
//  y los eventos del formulario de inicio de sesión.
//
//  ¿Qué hace exactamente?
//  - Captura el clic del botón "Iniciar sesión".
//  - Lee los valores de los campos de texto.
//  - Delega TODO al Controlador. No tiene "if" de negocio.
//  - Maneja el botón Salir y el switch de tema oscuro.
//
//  ¿Qué NO hace?
//  - No consulta la base de datos (eso es el Modelo).
//  - No decide si el usuario es Líder o Invitado (eso es
//    el Controlador).
//
//  REGLA DE ORO DE LA VISTA:
//  Si ves un "if" en la Vista que no sea de UI pura
//  (como "¿está activado este switch?"), probablemente
//  esa lógica debería estar en el Controlador.
// ============================================================

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

        // -------------------------------------------------------
        //  EVENTO: Clic en el botón "Iniciar sesión"
        //  Este evento es el punto de entrada de la HU-01.
        //
        //  La Vista hace exactamente tres cosas:
        //  1. Leer los valores de los campos.
        //  2. Llamar al Controlador con esos valores.
        //  3. Pasarse a sí misma (this) para que el Controlador
        //     pueda cerrarla cuando abra el formulario correcto.
        //
        //  ¡NADA MÁS! Todo lo demás es responsabilidad del Controlador.
        // -------------------------------------------------------
        private void btnIniciarsesion_Click(object sender, EventArgs e)
        {
            // PASO 1: Leemos los valores del formulario (solo la Vista sabe dónde están).
            string nombreIngresado = txtNomuser.Text.Trim();
            string passwordIngresada = txtContraseña.Text.Trim();

            // PASO 2: Delegamos la lógica al Controlador.
            // Llamada a: Controlador/LoginControlador.cs → método IniciarSesion(...)
            // El Controlador validará, consultará el Modelo y abrirá el formulario correcto.
            _loginControlador.IniciarSesion(nombreIngresado, passwordIngresada, this);
        }

        // -------------------------------------------------------
        //  EVENTO: Cambio en el switch de modo oscuro.
        //  Esta lógica sí pertenece a la Vista porque es
        //  puramente visual (no es una regla de negocio).
        //  AlternarTema() está definido en BaseMaterialForm.cs
        // -------------------------------------------------------
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
    }
}