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

namespace src.Vista
{
    public partial class FormCrearEvento : BaseMaterialForm
    {
        private readonly EventoControlador _eventoControlador;
        private readonly string _idLider;
        public FormCrearEvento(string idUsuario)
        {
            InitializeComponent();
            _idLider = idUsuario;
            _eventoControlador = new EventoControlador();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            bool exitoso = _eventoControlador.RegistrarEvento(materialTextBox2.Text.Trim(), materialTextBox3.Text.Trim(), dateTimePicker1.Value, dateTimePicker2.Value, _idLider);
            if (exitoso == true)
            {
                this.Close();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            // HACER DIALOGO DE CONFIRMACIÓN
            this.Close();
        }
    }
}
