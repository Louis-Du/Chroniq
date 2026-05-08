using MaterialSkin;
using MaterialSkin.Controls;
using src.Controlador;
using src.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace src.Vista
{
    // Panel principal del usuario Líder: crear, actualizar, deshabilitar eventos y agregar invitados.
    public partial class FormLider : BaseMaterialForm
    {
        // Se guarda el id del líder para pasárselo al controlador al crear eventos.
        private readonly string _idLider;
        private readonly EventoControlador _eventoControlador;

        /// <summary>
        /// Constructor: recibe nombre e Id del líder autenticado desde LoginControlador.
        /// </summary>
        public FormLider(string nombreUsuario, string idUsuario)
        {
            InitializeComponent();

            _idLider           = idUsuario;
            _eventoControlador = new EventoControlador();

            this.Text    = $"Chroniq - Líder: {nombreUsuario}";
            lblNomlid.Text = nombreUsuario;
        }

        private void FormLider_Load(object sender, EventArgs e)
        {
            CargarEventos();
        }

        // Consulta los eventos futuros y llena el DataGridView con los resultados.
        private void CargarEventos()
        {
            // ConsultarEventos() filtra eventos pasados y deshabilitados en el Controlador/Modelo.
            var eventos = _eventoControlador.ConsultarEventos();
            dgvEventos.AutoGenerateColumns = false;
            dgvEventos.DataSource = eventos;

            // Cada columna del DataGridView se enlaza a una propiedad de la clase Evento.
            _id.DataPropertyName             = "Id";
            codigoEvent.DataPropertyName     = "CodigoEvent";
            creadoPor.DataPropertyName       = "CreadoPor";
            nombreEvent.DataPropertyName     = "NombreEvent";
            tipoEvent.DataPropertyName       = "TipoEvent";
            fechahoraIniEvent.DataPropertyName = "FechahoraIniEvent";
            fechahoraFinEvent.DataPropertyName = "FechahoraFinEvent";
        }

        // Cierra este formulario y regresa al Login.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.Rows.Count == 0)
            {
                MessageBox.Show("No hay eventos para actualizar");
                return;
            }

            if (dgvEventos.CurrentRow == null)
            {
                MessageBox.Show("Por favor seleccione un evento");
                return;
            }

            var fila = dgvEventos.CurrentRow;

            if (fila.Cells["_id"].Value == null)
            {
                MessageBox.Show("Fila inválida");
                return;
            }

            string id = fila.Cells["_id"].Value.ToString();

            // Validamos que el código sea un número válido antes de convertir.
            if (fila.Cells["codigoEvent"].Value == null ||
                !int.TryParse(fila.Cells["codigoEvent"].Value.ToString(), out int codigo))
            {
                MessageBox.Show("Código de evento inválido");
                return;
            }

            string nombre     = fila.Cells["NombreEvent"].Value.ToString();
            string tipo       = fila.Cells["TipoEvent"].Value.ToString();
            string fechaInicio = fila.Cells["FechahoraIniEvent"].Value.ToString();
            string fechaFin   = fila.Cells["FechahoraFinEvent"].Value.ToString();

            FormActualizarEvento form = new FormActualizarEvento(id, codigo, nombre, tipo, fechaInicio, fechaFin);

            // Al cerrar el form de actualización, recargamos la tabla para reflejar cambios.
            form.FormClosed += (s, args) => CargarEventos();
            form.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearEvento frm = new FormCrearEvento(_idLider);

            // La lambda suscrita a FormClosed recarga eventos cuando el form de crear se cierra.
            frm.FormClosed += (s, args) => CargarEventos();
            frm.Show();
        }

        private void btnDeshabilitarEvento_Click(object sender, EventArgs e)
        {
            // Operador ?. evita NullReferenceException si CurrentRow es null.
            string id     = dgvEventos.CurrentRow?.Cells["_id"].Value?.ToString()        ?? "";
            string nombre = dgvEventos.CurrentRow?.Cells["NombreEvent"].Value?.ToString() ?? "";

            bool resultado = _eventoControlador.DeshabilitarEvento(id, nombre);

            // Solo recargamos la tabla si la operación fue exitosa.
            if (resultado) CargarEventos();
        }

        private void btnAgregarInvitado_Click(object sender, EventArgs e)
        {
            // DataBoundItem retorna el objeto Evento enlazado a la fila seleccionada en el grid.
            var eventoSeleccionado = (Evento)dgvEventos.CurrentRow.DataBoundItem;
            new FormAgregarInvitado(
                eventoSeleccionado.Id,
                eventoSeleccionado.FechahoraIniEvent,
                eventoSeleccionado.FechahoraFinEvent
            ).ShowDialog();
        }
    }
}
