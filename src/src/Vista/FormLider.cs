using MaterialSkin;
using MaterialSkin.Controls;
using src.Controlador; // Para usar EventoControlador
using src.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace src.Vista
{
    public partial class FormLider : BaseMaterialForm
    {
        // Guardamos el Id del líder autenticado para pasárselo
        // al Controlador en operaciones que lo necesiten.
        private readonly string _idLider;

        private readonly EventoControlador _eventoControlador;
        /// <summary>
        /// Constructor: recibe nombre e Id del líder autenticado.
        ///
        /// El LoginControlador lo llama así:
        ///   new FormLider(usuarioEncontrado.NombreUser, usuarioEncontrado.Id)
        /// </summary>
        /// <param name="nombreUsuario">Nombre del líder para mostrar en pantalla.</param>
        /// <param name="idUsuario">_id del líder en MongoDB, para operaciones del Controlador.</param>
        public FormLider(string nombreUsuario, string idUsuario)
        {
            InitializeComponent();

            _idLider = idUsuario;
            _eventoControlador = new EventoControlador();

            this.Text = $"Chroniq - Líder: {nombreUsuario}";
            lblNomlid.Text = nombreUsuario;
        }

        private void FormLider_Load(object sender, EventArgs e)
        {
            CargarEventos();
        }

        /// <summary>
        /// Consulta los eventos futuros y los carga en el DataGridView.
        /// </summary>
        private void CargarEventos()
        {
            // Llamada a: Controlador/EventoControlador.cs → ConsultarEventos()
            // Devuelve List<Evento> con los eventos cuya fecha de inicio
            // es superior a la fecha y hora actual.
            var eventos = _eventoControlador.ConsultarEventos();
            dgvEventos.AutoGenerateColumns = false;
            dgvEventos.DataSource = eventos;

            _id.DataPropertyName = "Id";
            codigoEvent.DataPropertyName = "CodigoEvent";
            creadoPor.DataPropertyName = "CreadoPor";
            nombreEvent.DataPropertyName = "NombreEvent";
            tipoEvent.DataPropertyName = "TipoEvent";
            fechahoraIniEvent.DataPropertyName = "FechahoraIniEvent";
            fechahoraFinEvent.DataPropertyName = "FechahoraFinEvent";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show(); // Cierra el formulario actual y vuelve al Login
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // 1. Validar si hay registros en el DataGridView
            if (dgvEventos.Rows.Count == 0)
            {
                MessageBox.Show("No hay eventos para actualizar");
                return;
            }

            // 2. Validar que haya una fila seleccionada
            if (dgvEventos.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione un evento");
                return;
            }

            //  3. Capturar datos de la fila seleccionada
            var fila = dgvEventos.CurrentRow;

            string _id = fila.Cells["_id"].Value.ToString();
            int codigo = int.Parse(fila.Cells["codigoEvent"].Value.ToString());
            string nombre = fila.Cells["NombreEvent"].Value.ToString();
            string tipo = fila.Cells["TipoEvent"].Value.ToString();
            string fechaInicio = fila.Cells["FechahoraIniEvent"].Value.ToString();
            string fechaFin = fila.Cells["FechahoraFinEvent"].Value.ToString();

            // 4. Llamar controlador
            EventoControlador controlador = new EventoControlador();

            controlador.AbrirFormularioActualizar(
            _id, codigo, nombre, tipo, fechaInicio, fechaFin
            );
        }

        // refactorizar
        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearEvento frm = new FormCrearEvento(_idLider);
            frm.FormClosed += (s, args) => CargarEventos();
            frm.Show();
        }

        private void btnAgregarInvitado_Click(object sender, EventArgs e)
        {
            var eventoSeleccionado = (Evento)dgvEventos.CurrentRow.DataBoundItem; // se utiliza var para acceder indirectamente a modelo por medio de controlador infiriendolo
            new FormAgregarInvitado(
                eventoSeleccionado.Id,
                eventoSeleccionado.FechahoraIniEvent,
                eventoSeleccionado.FechahoraFinEvent
            ).ShowDialog();
        }
    }
}
