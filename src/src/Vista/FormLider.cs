using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using src.Controlador; // Para usar EventoControlador

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

            creadoPor.DataPropertyName = "creadoPor";
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormCrearEvento frm = new FormCrearEvento(_idLider);
            frm.FormClosed += (s, args) => CargarEventos();
            frm.Show();
        }
    }
}
