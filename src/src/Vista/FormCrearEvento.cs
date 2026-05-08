using src.Controlador;
using src.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string nuevoId = _eventoControlador.RegistrarEvento(materialTextBox2.Text.Trim(), materialTextBox3.Text.Trim(), dateTimePicker1.Value, dateTimePicker2.Value, _idLider);
            if (nuevoId != null)
            {
                new FormAgregarInvitado(
                    nuevoId, 
                    dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss"), 
                    dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")
                ).ShowDialog();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la creación del evento?", "Volver al menú anterior", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
