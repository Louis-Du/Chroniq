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
        public FormActualizarEvento(string _id, int codigo, string nombre, string tipo, string fechaInicio, string fechaFin)
        {
            InitializeComponent();

            // cargar los datos del evento en los controles del formulario
            
            _idEvento = new ObjectId(_id);
            txtNombreEvent.Text = nombre;
            txtTipoEvent.Text = tipo;
            dtpFechaHoraInicio.Value = DateTime.Parse(fechaInicio);
            dtpFechaHoraFin.Value = DateTime.Parse(fechaFin);
        }

        private void btnAcept_Click(object sender, EventArgs e)
        {
            //// Llamar controlador
            EventoControlador controlador = new EventoControlador();
            controlador.RegistrarEvento(txtNombreEvent.Text, txtTipoEvent.Text, dtpFechaHoraInicio.Value, dtpFechaHoraFin.Value, _idEvento.ToString());
        }



    }
}
