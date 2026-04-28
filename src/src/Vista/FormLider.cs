// ============================================================
//  CAPA: VISTA  →  Archivo: FormLider.cs
// ============================================================
//  Formulario principal del usuario tipo Líder.
//  
//  Cambio respecto a la versión anterior:
//  Se añade un parámetro "nombreUsuario" al constructor
//  para que el Controlador pueda pasar el nombre del líder
//  autenticado y mostrarlo como bienvenida.
//
//  ¿Quién abre este formulario?
//  → El LoginControlador, desde Controlador/LoginControlador.cs
//    cuando detecta que el tipoUser es "Lider".
// ============================================================

using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    public partial class FormLider : BaseMaterialForm
    {
        /// <summary>
        /// Constructor actualizado: recibe el nombre del líder autenticado.
        /// El Controlador lo llama así:
        ///   new FormLider(usuarioEncontrado.NombreUser)
        /// </summary>
        /// <param name="nombreUsuario">Nombre del líder que inició sesión.</param>
        public FormLider(string nombreUsuario)
        {
            InitializeComponent();

            // Mostramos el nombre en el título del formulario como bienvenida.
            // Aquí también podrías actualizar una etiqueta del Designer.
            this.Text = $"Chroniq - Líder: {nombreUsuario}";

            lblNomlid.Text = nombreUsuario;
        }

        private void FormLider_Load(object sender, EventArgs e)
        {
            // Aquí irá la inicialización de los datos del Líder
            // en las próximas historias de usuario.
        }
    }
}