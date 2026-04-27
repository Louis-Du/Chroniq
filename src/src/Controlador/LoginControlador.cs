// ============================================================
//  CAPA: CONTROLADOR  →  Archivo: LoginControlador.cs
// ============================================================
//  RESPONSABILIDAD: Este archivo contiene TODA la lógica
//  del negocio para el inicio de sesión. Es el "cerebro"
//  que conecta la Vista con el Modelo.
//
//  ¿Qué hace exactamente?
//  1. Recibe los datos que el usuario escribió (nombre y contraseña).
//  2. Valida que esos datos no estén vacíos (validación básica).
//  3. Le pide al Modelo que busque el usuario en la BD.
//  4. Analiza el resultado: ¿existe? ¿qué tipo de usuario es?
//  5. Le ordena a la Vista qué formulario abrir (o muestra error).
//
//  ¿Qué NO hace?
//  - No sabe nada de MongoDB ni de cómo se hace la consulta
//    (eso es el Modelo).
//  - No maneja controles visuales como TextBox ni Buttons
//    (eso es la Vista).
//
//  FLUJO COMPLETO:
//  FormLogin (Vista) → llama a → LoginControlador (Controlador)
//                                    → llama a → UsuarioModelo (Modelo)
//                                    ← recibe ← Usuario (entidad)
//  FormLogin (Vista) ← recibe resultado ← LoginControlador
// ============================================================

using System.Windows.Forms;
using src.Modelo;  // Necesitamos UsuarioModelo y Usuario (entidad)
using src.Vista;   // Necesitamos FormLider y FormInvitado para abrirlos

namespace src.Controlador
{
    /// <summary>
    /// Controlador para la funcionalidad de inicio de sesión (HU-01).
    /// La Vista lo instancia y delega toda la lógica aquí.
    /// </summary>
    public class LoginControlador
    {
        // El Controlador tiene una referencia al Modelo de usuarios.
        // Se crea una sola vez cuando el Controlador es instanciado.
        // La Vista nunca toca el Modelo directamente.
        private readonly UsuarioModelo _usuarioModelo;

        /// <summary>
        /// Constructor del controlador.
        /// Se ejecuta cuando la Vista hace: new LoginControlador()
        /// Aquí preparamos el Modelo que vamos a usar.
        /// </summary>
        public LoginControlador()
        {
            // Instanciamos el Modelo. El Modelo internamente
            // llamará a Conexion.ObtenerBaseDatos(), pero el
            // Controlador no necesita saber eso.
            _usuarioModelo = new UsuarioModelo();
        }

        /// <summary>
        /// Método principal del inicio de sesión. (HU-01)
        ///
        /// ¿Cómo lo llama la Vista (FormLogin)?
        ///   LoginControlador controlador = new LoginControlador();
        ///   controlador.IniciarSesion("Miguel David", "lider1", this);
        ///
        /// Parámetros:
        ///   nombreUser   → texto del campo txtNomuser en el formulario
        ///   passwordUser → texto del campo txtContraseña en el formulario
        ///   formularioActual → referencia al FormLogin para poder cerrarlo
        ///                      después de abrir el formulario correcto
        /// </summary>
        public void IniciarSesion(string nombreUser, string passwordUser, Form formularioActual)
        {
            // --------------------------------------------------
            //  PASO 1: Validación de campos vacíos
            //  Esta validación es responsabilidad del Controlador
            //  porque es una regla del negocio ("los campos
            //  son obligatorios"), no un problema de UI.
            // --------------------------------------------------
            if (string.IsNullOrWhiteSpace(nombreUser) || string.IsNullOrWhiteSpace(passwordUser))
            {
                MessageBox.Show(
                    "Por favor, ingresa el nombre de usuario y la contraseña.",
                    "Campos requeridos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Detenemos la ejecución aquí.
            }

            // --------------------------------------------------
            //  PASO 2: Consulta al Modelo
            //  Le pedimos al Modelo que busque el usuario.
            //  El Controlador NO sabe cómo funciona MongoDB;
            //  solo sabe que el Modelo le devolverá un Usuario o null.
            //
            //  Llamada:  _usuarioModelo.BuscarPorCredenciales(...)
            //  Está definida en: Modelo/UsuarioModelo.cs
            // --------------------------------------------------
            Usuario usuarioEncontrado = _usuarioModelo.BuscarPorCredenciales(nombreUser, passwordUser);

            // --------------------------------------------------
            //  PASO 3: Lógica del negocio sobre el resultado
            //  Aquí viven los "if" y las decisiones importantes.
            //  Esta es la parte que antes mezclaban en "consultas".
            // --------------------------------------------------

            // Caso A: Credenciales incorrectas → el Modelo devolvió null
            if (usuarioEncontrado == null)
            {
                MessageBox.Show(
                    "Usuario o contraseña incorrectos. Intenta de nuevo.",
                    "Acceso denegado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Caso B: El usuario existe → revisamos su tipo (Lider / Invitado)
            // El campo "tipoUser" viene de la BD a través de la entidad Usuario.
            if (usuarioEncontrado.TipoUser == "Lider")
            {
                // Es Líder: abrimos el formulario del Líder.
                // Pasamos el nombre para personalizar la bienvenida.
                AbrirFormulario(new FormLider(usuarioEncontrado.NombreUser), formularioActual);
            }
            else if (usuarioEncontrado.TipoUser == "Invitado")
            {
                // Es Invitado: abrimos el formulario del Invitado.
                AbrirFormulario(new FormInvitado(usuarioEncontrado.NombreUser), formularioActual);
            }
            else
            {
                // Caso C: El tipo de usuario no es reconocido (dato corrupto en BD)
                MessageBox.Show(
                    $"El tipo de usuario '{usuarioEncontrado.TipoUser}' no está configurado en el sistema.",
                    "Error de configuración",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } 
        }

        /// <summary>
        /// Método auxiliar privado: abre el formulario destino
        /// y cierra el formulario actual (FormLogin).
        ///
        /// Es privado porque solo lo usa este controlador internamente.
        /// La Vista no necesita saber que existe.
        /// </summary>
        /// <param name="formularioDestino">El nuevo formulario a mostrar.</param>
        /// <param name="formularioActual">El FormLogin que se va a cerrar.</param>
        private void AbrirFormulario(Form formularioDestino, Form formularioActual)
        {
            formularioDestino.Show();   // Muestra el nuevo formulario
            formularioActual.Hide();    // Oculta el login (no se destruye por si acaso)
        }
    }
}