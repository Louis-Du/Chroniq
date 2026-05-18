// ============================================================
//  CAPA: VISTA  →  Archivo: FormInvitado.cs
// ============================================================
//  Formulario principal del usuario tipo Invitado.
//
//  ¿Quién abre este formulario?
//  → El LoginControlador, desde Controlador/LoginControlador.cs
//    cuando detecta que el tipoUser es "Invitado".
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
        private readonly string _idUsuario;

        public FormInvitado(string nombreUsuario, string idUsuario)
        {
            InitializeComponent();

            _idUsuario = idUsuario;
            _eventoControlador = new EventoControlador();

            this.Text = $"Chroniq - Invitado: {nombreUsuario}";
        }

        private void FormInvitado_Load(object sender, EventArgs e)
        {
            CargarEventos();
        }

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show(); // Cierra el formulario actual y vuelve al Login
        }
    }
}