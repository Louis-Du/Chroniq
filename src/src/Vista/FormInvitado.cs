// ============================================================
//  CAPA: VISTA  →  Archivo: FormInvitado.cs
// ============================================================
//  Panel principal del usuario Invitado: muestra sus eventos asignados.
//  Lo abre el LoginControlador cuando detecta tipoUser == "Invitado".
// ============================================================

using MaterialSkin;
using MaterialSkin.Controls;
using src.Controlador;
using src.Modelo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace src.Vista
{
    public partial class FormInvitado : BaseMaterialForm
    {
        private readonly EventoControlador _eventoControlador;
        // Guardamos el id del usuario para consultarle sus eventos asignados.
        private readonly string _idUsuario;

        public FormInvitado(string nombreUsuario, string idUsuario)
        {
            InitializeComponent();

            _idUsuario         = idUsuario;
            _eventoControlador = new EventoControlador();

            this.Text = $"Chroniq - Invitado: {nombreUsuario}";
        }

        private void FormInvitado_Load(object sender, EventArgs e)
        {
            CargarEventos();
        }

        // Consulta y muestra en el DataGridView los eventos futuros donde el invitado está inscrito.
        private void CargarEventos()
        {
            List<Evento> eventos = _eventoControlador.ObtenerEventosPorInvitado(_idUsuario);

            dgInvitEventos.Rows.Clear();

            if (eventos.Count == 0)
            {
                MessageBox.Show("No tienes eventos asignados próximos.",
                    "Sin eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Agregamos cada evento como una fila manual; el orden debe coincidir con las columnas del Designer.
            foreach (var ev in eventos)
            {
                dgInvitEventos.Rows.Add(
                    ev.CodigoEvent,
                    ev.NombreEvent,
                    ev.TipoEvent,
                    ev.FechahoraIniEvent,
                    ev.FechahoraFinEvent
                );
            }
        }

        // Cierra este formulario y regresa al Login.
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }
    }
}
