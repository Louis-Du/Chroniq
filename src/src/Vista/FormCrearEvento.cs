using src.Controlador;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    public partial class FormCrearEvento : BaseMaterialForm
    {
        private readonly EventoControlador _eventoControlador;
        private readonly string _idLider;

        public FormCrearEvento(string idLider)
        {
            InitializeComponent();
            _idLider = idLider;
            _eventoControlador = new EventoControlador();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Combinamos fecha (solo Date) + hora (solo TimeOfDay) en un único DateTime.
            // Así el controlador recibe el dato completo sin saber cómo se capturó en la Vista.
            DateTime fechaInicio = dateTimePicker1.Value.Date + timePicker1.Value.TimeOfDay;
            DateTime fechaFin    = dateTimePicker2.Value.Date + timePicker2.Value.TimeOfDay;

            string nuevoId = _eventoControlador.RegistrarEvento(
                materialTextBox2.Text.Trim(),
                materialTextBox3.Text.Trim(),
                fechaInicio,
                fechaFin,
                _idLider);

            if (nuevoId != null)
            {
                new FormAgregarInvitado(
                    nuevoId,
                    fechaInicio.ToString("yyyy-MM-dd HH:mm:ss"),
                    fechaFin.ToString("yyyy-MM-dd HH:mm:ss")
                ).ShowDialog();

                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas cancelar la creación del evento?",
                "Volver al menú anterior", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
