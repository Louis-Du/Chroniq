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
            // RegistrarEvento retorna el nuevo _id si fue exitoso, null si falló o hay conflicto.
            string nuevoId = _eventoControlador.RegistrarEvento(
                materialTextBox2.Text.Trim(),
                materialTextBox3.Text.Trim(),
                dateTimePicker1.Value,
                dateTimePicker2.Value,
                _idLider);

            if (nuevoId != null)
            {
                new FormAgregarInvitado(
                    nuevoId,
                    dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"),
                    dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")
                ).ShowDialog();

                // CORRECCIÓN: cerrar FormCrearEvento después de abrir FormAgregarInvitado;
                // sin esto el formulario queda abierto al volver de agregar invitados.
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro que deseas cancelar la creación del evento?",
                "Volver al menú anterior", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}