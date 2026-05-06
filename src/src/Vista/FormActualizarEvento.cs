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
            // 🔴 Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtNombreEvent.Text) ||
                string.IsNullOrWhiteSpace(txtTipoEvent.Text))
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            if (dtpFechaHoraFin.Value < dtpFechaHoraInicio.Value)
            {
                MessageBox.Show("La fecha final no puede ser menor a la inicial");
                return;
            }

            // 📦 Obtener datos del formulario
            string nombre = txtNombreEvent.Text;
            string tipo = txtTipoEvent.Text;
            string fechaIni = dtpFechaHoraInicio.Value.ToString("yyyy-MM-dd");
            string fechaFin = dtpFechaHoraFin.Value.ToString("yyyy-MM-dd");

            // Llamar controlador
            EventoControlador controlador = new EventoControlador();

            bool actualizado = controlador.ActualizarEvento(
                _idEvento, nombre, tipo, fechaIni, fechaFin
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



    }
}
