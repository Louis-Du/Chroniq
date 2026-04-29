// ============================================================
//  CAPA: CONTROLADOR  →  Archivo: EventoControlador.cs
// ============================================================
//  Historias cubiertas:
//  HU-02: Registrar eventos
//  HU-03: Consultar eventos
// ============================================================

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using src.Modelo; // RED: EventoModelo aún no existe.

namespace src.Controlador
{
    public class EventoControlador
    {
        // Formato de fecha que usa la colección Eventos en MongoDB.
        // Ejemplo: "2026-05-15 09:30:00"
        private const string FORMATO_FECHA_BD = "yyyy-MM-dd HH:mm:ss";

        // RED: EventoModelo no existe aún → error de compilación esperado.
        private readonly EventoModelo _eventoModelo;

        public EventoControlador()
        {
            // RED: No compilará hasta que exista Modelo/EventoModelo.cs
            _eventoModelo = new EventoModelo();
        }


        // ============================================================
        //  HU-02: Registrar evento
        // ============================================================

        /// <summary>
        /// Registra un nuevo evento en la BD. (HU-02)
        ///
        /// Como lo llama la Vista (FormCrearEvento):
        ///   _eventoControlador.RegistrarEvento(
        ///       txtNombreEvento.Text,
        ///       cmbTipoEvento.Text,
        ///       dtpFechaHoraInicio.Value,
        ///       dtpFechaHoraFin.Value,
        ///       _idLider
        ///   );
        /// </summary>
        public void RegistrarEvento(
            string nombreEvent,
            string tipoEvent,
            DateTime fechaHoraInicio,
            DateTime fechaHoraFin,
            string idLider)
        {
            // TAREA 1: Validar campos de texto vacíos.
            if (string.IsNullOrWhiteSpace(nombreEvent))
            {
                MessageBox.Show("El nombre del evento es obligatorio.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(tipoEvent))
            {
                MessageBox.Show("Debes seleccionar un tipo de evento.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TAREA 2: Validar que fin no sea anterior o igual a inicio.
            if (fechaHoraFin <= fechaHoraInicio)
            {
                MessageBox.Show("La fecha y hora de fin debe ser posterior a la de inicio.",
                    "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TAREA 3: Convertir DateTime a string con el formato de la BD.
            // La BD guarda las fechas como texto: "2026-05-15 09:30:00"
            string fechaIniStr = fechaHoraInicio.ToString(FORMATO_FECHA_BD);
            string fechaFinStr = fechaHoraFin.ToString(FORMATO_FECHA_BD);

            // TAREA 4: Enviar al Modelo.
            // RED: GuardarEvento debe existir en EventoModelo con esta firma:
            //   public bool GuardarEvento(string nombreEvent, string tipoEvent,
            //       string fechahoraIniEvent, string fechahoraFinEvent, string idLider)
            bool guardadoExitoso = _eventoModelo.GuardarEvento(
                nombreEvent, tipoEvent, fechaIniStr, fechaFinStr, idLider);

            if (guardadoExitoso)
                MessageBox.Show($"El evento '{nombreEvent}' fue registrado correctamente.",
                    "Evento registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo registrar el evento. El horario seleccionado ya está ocupado.",
                    "Conflicto de horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        // ============================================================
        //  HU-03: Consultar eventos
        // ============================================================

        /// <summary>
        /// Obtiene los eventos cuya fecha de inicio es superior a la
        /// fecha y hora actual. La Vista los asigna al DataGridView.
        ///
        /// Como lo llama la Vista (FormLider):
        ///   var eventos = _eventoControlador.ConsultarEventos();
        ///   dgvEventos.DataSource = eventos;
        ///
        /// Retorna lista vacía si no hay eventos, nunca null,
        /// para que la Vista no tenga que verificar antes de asignar al grid.
        /// </summary>
        public List<Evento> ConsultarEventos()
        {
            // Convertimos la fecha actual al mismo formato string de la BD
            // para que el Modelo pueda comparar directamente.
            // El formato "yyyy-MM-dd HH:mm:ss" es ordenable alfabéticamente,
            // así que comparar strings da el mismo resultado que comparar fechas.
            string ahora = DateTime.Now.ToString(FORMATO_FECHA_BD);

            // RED: ObtenerEventosFuturos no existe aún en EventoModelo.
            // El equipo del Modelo debe crear este método con la firma:
            //
            //   public List<Evento> ObtenerEventosFuturos(string fechaHoraActual)
            //
            // Responsabilidades del Modelo en ese método:
            // → Consultar la colección Eventos en MongoDB.
            // → Filtrar solo donde fechahoraIniEvent > fechaHoraActual.
            // → Retornar lista vacía (nunca null) si no hay resultados.
            List<Evento> eventos = _eventoModelo.ObtenerEventos(ahora);

            if (eventos.Count == 0)
                MessageBox.Show("No hay eventos programados próximamente.",
                    "Sin eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return eventos;
        }
    }
}
