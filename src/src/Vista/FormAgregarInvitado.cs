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

            CargarInvitados();
        }

        private void CargarInvitados()
        {
            var invitados = _eventoControlador.ObtenerInvitados();

            dgvInvitados.AutoGenerateColumns = false;
            dgvInvitados.DataSource = invitados;

            // DataPropertyName apunta a las propiedades de Usuario.cs
            nombreUser.DataPropertyName = "NombreUser";
            edadUser.DataPropertyName = "EdadUser";
            generoUser.DataPropertyName = "GeneroUser";
            emailUser.DataPropertyName = "EmailUser";
            telefonoUser.DataPropertyName = "TelefonoUser";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInvitarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar que haya una fila seleccionada en el grid
            if (dgvInvitados.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un invitado de la lista.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtenemos el Id del invitado desde la fila seleccionada.
            // DataBoundItem devuelve el objeto Usuario de esa fila.
            var invitadoSeleccionado = (src.Modelo.Usuario)dgvInvitados.CurrentRow.DataBoundItem;

            bool ok = _eventoControlador.AgregarInvitado(
                _idEvento,
                invitadoSeleccionado.Id,
                _fechaIni,
                _fechaFin);

            if (ok) this.Close();
        }
    }
}
