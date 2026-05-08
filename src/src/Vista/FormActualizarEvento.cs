using MongoDB.Bson;
using src.Controlador;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    // Formulario modal para editar nombre, tipo y fechas de un evento existente.
    public partial class FormActualizarEvento : BaseMaterialForm
    {
        private readonly EventoControlador _eventoControlador;
        // Guardamos el id como ObjectId porque el Modelo lo requiere en ese tipo.
        private ObjectId _idEvento;

        public FormActualizarEvento(string id, int codigo, string nombre, string tipo,
            string fechaHoraIni, string fechaHoraFin)
        {
            InitializeComponent();
            _eventoControlador = new EventoControlador();

            // TryParse evita crash si el string de fecha viene con formato inesperado o vacío.
            if (!DateTime.TryParse(fechaHoraIni, out DateTime parsedInicio)) parsedInicio = DateTime.Now;
            if (!DateTime.TryParse(fechaHoraFin, out DateTime parsedFin))    parsedFin    = DateTime.Now;

            // Separamos fecha y hora en controles distintos para que el usuario pueda editarlos por separado.
            dtpFechaHoraInicio.Value = parsedInicio.Date;
            tpHoraInicio.Value       = parsedInicio;
            dtpFechaHoraFin.Value    = parsedFin.Date;
            tpHoraFin.Value          = parsedFin;

            txtNombreEvent.Text = nombre;
            txtTipoEvent.Text   = tipo;

            // Convertimos el string id a ObjectId para usarlo en las operaciones del Modelo.
            _idEvento = ObjectId.Parse(id);
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            // Reconstruimos el DateTime completo combinando fecha del DatePicker y hora del TimePicker.
            DateTime fechaInicio = dtpFechaHoraInicio.Value.Date + tpHoraInicio.Value.TimeOfDay;
            DateTime fechaFin    = dtpFechaHoraFin.Value.Date    + tpHoraFin.Value.TimeOfDay;

            bool actualizado = _eventoControlador.ActualizarEvento(
                txtNombreEvent.Text, txtTipoEvent.Text,
                fechaInicio, fechaFin, _idEvento);

            // Solo cerramos el formulario si la actualización fue exitosa.
            if (actualizado) this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
