using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.Controlador; // Para usar EventoControlador
namespace src.Vista
{
    public partial class FormActualizarEvento : BaseMaterialForm
    {
        private ObjectId _idEvento;
        private readonly EventoControlador _eventoControlador;
        public FormActualizarEvento(string _id, int codigo, string nombre, string tipo, string fechaHoraIni, string fechaHoraFin)
        {
            InitializeComponent();
            _eventoControlador = new EventoControlador();

            // cargar los datos del evento en los controles del formulario
            dtpFechaHoraInicio.Value = DateTime.Parse(fechaHoraIni);
            dtpFechaHoraFin.Value = DateTime.Parse(fechaHoraFin);
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {

            bool actualizado = _eventoControlador.ActualizarEvento(
                txtNombreEvent.Text, txtTipoEvent.Text, dtpFechaHoraInicio.Value, dtpFechaHoraFin.Value, _idEvento
            );

            if (actualizado)
            {
                MessageBox.Show("Evento actualizado correctamente");
                this.Close(); // cerrar form
            }
            else
            {
                MessageBox.Show("Error al actualizar el evento");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmar cancelación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}