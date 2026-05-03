using System;
using System.Collections.Generic;
using System.Windows.Forms;
using src.Modelo; 

namespace src.Controlador
{
    public class EventoControlador
    {
        // Formato de fecha que usa la colección Eventos en MongoDB.
        // Ejemplo: "2026-05-15 09:30:00"
        private const string FORMATO_FECHA_BD = "yyyy-MM-dd HH:mm:ss";

        private readonly EventoModelo _eventoModelo;

        public EventoControlador()
        {
            _eventoModelo = new EventoModelo();
        }

        public void RegistrarEvento(string nombreEvent, string tipoEvent, DateTime fechaHoraInicio, DateTime fechaHoraFin, string idLider)
        {
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

            if (fechaHoraFin <= fechaHoraInicio)
            {
                MessageBox.Show("La fecha y hora de fin debe ser posterior a la de inicio.",
                    "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir DateTime a string con el formato de la BD.
            // La BD guarda las fechas como texto: "2026-05-15 09:30:00"
            string fechaIniStr = fechaHoraInicio.ToString(FORMATO_FECHA_BD);
            string fechaFinStr = fechaHoraFin.ToString(FORMATO_FECHA_BD);

            bool guardadoExitoso = _eventoModelo.GuardarEvento(
                nombreEvent, tipoEvent, fechaIniStr, fechaFinStr, idLider);

            if (guardadoExitoso)
                MessageBox.Show($"El evento '{nombreEvent}' fue registrado correctamente.",
                    "Evento registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo registrar el evento. El horario seleccionado ya está ocupado.",
                    "Conflicto de horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public List<Evento> ConsultarEventos()
        {
            // Convertimos la fecha actual al mismo formato string de la BD
            // para que el Modelo pueda comparar directamente.
            string ahora = DateTime.Now.ToString(FORMATO_FECHA_BD);

            List<Evento> eventos = _eventoModelo.ObtenerEventos(ahora);

            if (eventos.Count == 0)
                MessageBox.Show("No hay eventos programados próximamente.",
                    "Sin eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return eventos;
        }
       
        public void AbrirFormularioActualizar(string id, int codigo, string nombre, string tipo, string fechaInicio, string fechaFin)
        {
            FormActualizarEvento form = new FormActualizarEvento(
                id, codigo, nombre, tipo, fechaInicio, fechaFin
            );

            form.ShowDialog();
        }
    }
}
