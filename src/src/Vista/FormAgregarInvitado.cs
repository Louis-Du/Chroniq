using src.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace src.Vista
{
    public partial class FormAgregarInvitado : Form
    {
        private readonly EventoControlador _eventoControlador;

        // Campos para guardar los datos del evento recibidos en el constructor
        private readonly string _idEvento;
        private readonly string _fechaIni;
        private readonly string _fechaFin;

        public FormAgregarInvitado(string idEvento, string FechahoraIniEvent, string FechahoraFinEvent)
        {
            InitializeComponent();

            _eventoControlador = new EventoControlador();

            // Guardar los parámetros en los campos para usarlos en el botón
            _idEvento = idEvento;
            _fechaIni = FechahoraIniEvent;
            _fechaFin = FechahoraFinEvent;

            CargarUsuariosDisponibles();
            CargarInvitadosActuales();

        }

        private void CargarUsuariosDisponibles()
        {
            var invitados = _eventoControlador.ObtenerInvitados(_idEvento);

            dgvUsuariosDisponibles.AutoGenerateColumns = false;
            dgvUsuariosDisponibles.DataSource = invitados;

            numeroCedula.DataPropertyName = "NumeroCedula";
            nombreUser.DataPropertyName = "NombreUser";
            edadUser.DataPropertyName = "EdadUser";
            generoUser.DataPropertyName = "GeneroUser";
            emailUser.DataPropertyName = "EmailUser";
            telefonoUser.DataPropertyName = "TelefonoUser";
        }

        private void CargarInvitadosActuales()
        {
            var inscritos = _eventoControlador.ObtenerInscriptos(_idEvento);
            dgvInscritos.AutoGenerateColumns = false;
            dgvInscritos.DataSource = inscritos;
            
            numeroCedulaInscrito.DataPropertyName = "NumeroCedula";
            nombreInscrito.DataPropertyName = "NombreUser";
            edadInscrito.DataPropertyName = "EdadUser";
            generoInscrito.DataPropertyName = "GeneroUser";
            emailInscrito.DataPropertyName = "EmailUser";
            telefonoInscrito.DataPropertyName = "TelefonoUser";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que dejar de agregar invitados?", "Volver al menú anterior", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnInvitarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada en el grid
            if (dgvUsuariosDisponibles.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un invitado de la lista.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el Id del invitado desde la fila seleccionada.
            // DataBoundItem devuelve el objeto Usuario de esa fila.
            var invitadoSeleccionado = (src.Modelo.Usuario)dgvUsuariosDisponibles.CurrentRow.DataBoundItem;

            bool ok = _eventoControlador.AgregarInvitado(_idEvento, invitadoSeleccionado.Id, _fechaIni, _fechaFin);

            if (ok)
            {
                CargarInvitadosActuales();
                CargarUsuariosDisponibles();
            }
        }

        private void btnCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            FormCrearInvitado frm = new FormCrearInvitado();
            frm.FormClosed += (s, args) => CargarUsuariosDisponibles();             
            frm.Show();
        }
    }
}
