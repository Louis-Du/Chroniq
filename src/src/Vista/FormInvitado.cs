// ============================================================
//  CAPA: VISTA  →  Archivo: FormInvitado.cs
// ============================================================
//  Formulario principal del usuario tipo Invitado.
//
//  ¿Quién abre este formulario?
//  → El LoginControlador, desde Controlador/LoginControlador.cs
//    cuando detecta que el tipoUser es "Invitado".
// ============================================================

using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    public partial class FormInvitado : BaseMaterialForm
    {
        /// <summary>
        /// Constructor actualizado: recibe el nombre del invitado autenticado.
        /// El Controlador lo llama así:
        ///   new FormInvitado(usuarioEncontrado.NombreUser)
        /// </summary>
        /// <param name="nombreUsuario">Nombre del invitado que inició sesión.</param>
        public FormInvitado(string nombreUsuario)
        {
            InitializeComponent();

            // Mostramos el nombre en el título del formulario como bienvenida.
            this.Text = $"Chroniq - Invitado: {nombreUsuario}";

        }

        private void FormInvitado_Load(object sender, EventArgs e)
        {
            // Aquí irá la carga de los eventos asignados al invitado
            // en las próximas historias de usuario (HU-07).
        }
    }
}