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
        // al Controlador en operaciones que lo necesiten (HU-02, HU-05).
        // La Vista no lo usa directamente, solo lo conserva.
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
            // HU-03: Al cargar el formulario consultamos los eventos
            // y los asignamos al grid que el compañero diseñó en el Designer.
            //
            // Llamada a: Controlador/EventoControlador.cs → ConsultarEventos()
            // El Controlador le pide al Modelo los eventos futuros y los devuelve.
            CargarEventos();
        }

        /// <summary>
        /// Consulta los eventos futuros y los carga en el DataGridView.
        /// Se llama al abrir el formulario y puede llamarse de nuevo
        /// si se agrega un botón "Actualizar" en el futuro.
        ///
        /// El compañero de Vista debe asegurarse de que el DataGridView
        /// se llame dgvEventos en el Designer para que esta línea funcione.
        /// </summary>
        private void CargarEventos()
        {
            // Llamada a: Controlador/EventoControlador.cs → ConsultarEventos()
            // Devuelve List<Evento> con los eventos cuya fecha de inicio
            // es superior a la fecha y hora actual.
            var eventos = _eventoControlador.ConsultarEventos();
            // Asignamos la lista al DataGridView.
            // El grid mostrará automáticamente las propiedades de Evento
            // como columnas: NombreEvent, TipoEvent, FechahoraIniEvent, etc.
            dgvEventos.DataSource = eventos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show(); // Cierra el formulario actual y vuelve al Login
        }
    }
}
