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
    // Formulario para agregar invitados a un evento; muestra disponibles e inscritos en dos grids.
    public partial class FormAgregarInvitado : Form
    {
        private readonly EventoControlador _eventoControlador;

        // Datos del evento recibidos en el constructor; se necesitan para verificar conflictos de horario.
        private readonly string _idEvento;
        private readonly string _fechaIni;
        private readonly string _fechaFin;

        public FormAgregarInvitado(string idEvento, string FechahoraIniEvent, string FechahoraFinEvent)
        {
            InitializeComponent();

            _eventoControlador = new EventoControlador();
            _idEvento = idEvento;
            _fechaIni = FechahoraIniEvent;
            _fechaFin = FechahoraFinEvent;

            // Cargamos ambas listas al abrir el formulario.
            CargarUsuariosDisponibles();
            CargarInvitadosActuales();
        }

        // Muestra los invitados que aún NO están inscritos en este evento.
        private void CargarUsuariosDisponibles()
        {
            var invitados = _eventoControlador.ObtenerInvitados(_idEvento);

            dgvUsuariosDisponibles.AutoGenerateColumns = false;
            dgvUsuariosDisponibles.DataSource = invitados;

            // Enlazamos cada columna del grid a la propiedad correspondiente del objeto Usuario.
            numeroCedula.DataPropertyName = "NumeroCedula";
            nombreUser.DataPropertyName   = "NombreUser";
            edadUser.DataPropertyName     = "EdadUser";
            generoUser.DataPropertyName   = "GeneroUser";
            emailUser.DataPropertyName    = "EmailUser";
            telefonoUser.DataPropertyName = "TelefonoUser";
        }

        // Muestra los invitados que YA están inscritos en este evento.
        private void CargarInvitadosActuales()
        {
            var inscritos = _eventoControlador.ObtenerInscriptos(_idEvento);
            dgvInscritos.AutoGenerateColumns = false;
            dgvInscritos.DataSource = inscritos;

            numeroCedulaInscrito.DataPropertyName = "NumeroCedula";
            nombreInscrito.DataPropertyName       = "NombreUser";
            edadInscrito.DataPropertyName         = "EdadUser";
            generoInscrito.DataPropertyName       = "GeneroUser";
            emailInscrito.DataPropertyName        = "EmailUser";
            telefonoInscrito.DataPropertyName     = "TelefonoUser";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro que dejar de agregar invitados?",
                "Volver al menú anterior", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnInvitarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuariosDisponibles.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un invitado de la lista.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // DataBoundItem retorna el objeto Usuario real enlazado a la fila seleccionada.
            var invitadoSeleccionado = (src.Modelo.Usuario)dgvUsuariosDisponibles.CurrentRow.DataBoundItem;

            bool ok = _eventoControlador.AgregarInvitado(
                _idEvento, invitadoSeleccionado.Id, _fechaIni, _fechaFin);

            // Si se agregó correctamente, actualizamos ambos grids para reflejar el cambio.
            if (ok)
            {
                CargarInvitadosActuales();
                CargarUsuariosDisponibles();
            }
        }

        private void btnCrearNuevoUsuario_Click(object sender, EventArgs e)
        {
            FormCrearInvitado frm = new FormCrearInvitado();

            // Al cerrar el form de crear invitado, recargamos disponibles por si el nuevo aparece.
            frm.FormClosed += (s, args) => CargarUsuariosDisponibles();
            frm.Show();
        }
    }
}
