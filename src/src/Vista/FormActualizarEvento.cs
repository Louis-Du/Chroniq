using MongoDB.Bson;
using src.Controlador;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    public partial class FormActualizarEvento : BaseMaterialForm
    {
        private readonly EventoControlador _eventoControlador;
        private ObjectId _idEvento;

        public FormActualizarEvento(string id, int codigo, string nombre, string tipo,
            string fechaHoraIni, string fechaHoraFin)
        {
            InitializeComponent();
            _eventoControlador = new EventoControlador();

            // TryParse evita crash si el string de fecha viene con formato inesperado.
            if (!DateTime.TryParse(fechaHoraIni, out DateTime parsedInicio)) parsedInicio = DateTime.Now;
            if (!DateTime.TryParse(fechaHoraFin, out DateTime parsedFin))    parsedFin    = DateTime.Now;

            // Cargamos fecha y hora en controles separados para que el usuario pueda editarlos independientemente.
            dtpFechaHoraInicio.Value = parsedInicio.Date;
            tpHoraInicio.Value       = parsedInicio;
            dtpFechaHoraFin.Value    = parsedFin.Date;
            tpHoraFin.Value          = parsedFin;

            txtNombreEvent.Text = nombre;
            txtTipoEvent.Text   = tipo;

            _idEvento = ObjectId.Parse(id);
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            // Combinamos fecha + hora en un único DateTime antes de pasar al controlador.
            DateTime fechaInicio = dtpFechaHoraInicio.Value.Date + tpHoraInicio.Value.TimeOfDay;
            DateTime fechaFin    = dtpFechaHoraFin.Value.Date    + tpHoraFin.Value.TimeOfDay;

            bool actualizado = _eventoControlador.ActualizarEvento(
                txtNombreEvent.Text, txtTipoEvent.Text,
                fechaInicio, fechaFin, _idEvento);

            if (actualizado) this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
