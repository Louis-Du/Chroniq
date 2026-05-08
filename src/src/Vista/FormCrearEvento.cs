using src.Controlador;
using System;
using System.Windows.Forms;

namespace src.Vista
{
    // Formulario para que el líder cree un nuevo evento con nombre, tipo y rango de fechas/horas.
    public partial class FormCrearEvento : BaseMaterialForm
    {
        private readonly EventoControlador _eventoControlador;
        // Guardamos el id del líder para asociárselo al evento al guardarlo.
        private readonly string _idLider;

        public FormCrearEvento(string idLider)
        {
            InitializeComponent();
            _idLider           = idLider;
            _eventoControlador = new EventoControlador();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Combinamos la parte Date del DatePicker con la parte Time del TimePicker
            // para obtener un DateTime completo (fecha + hora) que el controlador necesita.
            DateTime fechaInicio = dateTimePicker1.Value.Date + timePicker1.Value.TimeOfDay;
            DateTime fechaFin    = dateTimePicker2.Value.Date + timePicker2.Value.TimeOfDay;

            string nuevoId = _eventoControlador.RegistrarEvento(
                materialTextBox2.Text.Trim(),
                materialTextBox3.Text.Trim(),
                fechaInicio,
                fechaFin,
                _idLider);

            // Si el registro fue exitoso, abrimos el formulario de invitados inmediatamente.
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
