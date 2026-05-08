
using MongoDB.Bson;
using src.Modelo;
using src.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace src.Controlador
{
    // Controlador que centraliza la lógica de negocio para eventos e invitados.
    public class EventoControlador
    {
        // Formato usado para convertir DateTime a string antes de guardar en MongoDB.
        // La BD almacena las fechas como texto, por eso usamos siempre este mismo formato.
        private const string FORMATO_FECHA_BD = "yyyy-MM-dd HH:mm:ss";

        private readonly EventoModelo  _eventoModelo;
        private readonly UsuarioModelo _usuarioModelo;

        public EventoControlador()
        {
            _eventoModelo  = new EventoModelo();
            _usuarioModelo = new UsuarioModelo();
        }

        // Valida los datos del formulario y llama al Modelo para guardar el evento;
        // retorna el _id del nuevo evento o null si falló la validación o hay conflicto.
        public string RegistrarEvento(string nombreEvent, string tipoEvent,
            DateTime fechaHoraInicio, DateTime fechaHoraFin, string idLider)
        {
            if (string.IsNullOrWhiteSpace(nombreEvent))
            {
                MessageBox.Show("El nombre del evento es obligatorio.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (string.IsNullOrWhiteSpace(tipoEvent))
            {
                MessageBox.Show("Debes seleccionar un tipo de evento.",
                    "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // La fecha de fin debe ser estrictamente posterior a la de inicio.
            if (fechaHoraFin <= fechaHoraInicio)
            {
                MessageBox.Show("La fecha y hora de fin debe ser posterior a la de inicio.",
                    "Rango de fechas inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            // Convertimos DateTime a string con el formato de la BD para comparar en MongoDB.
            string fechaIniStr = fechaHoraInicio.ToString(FORMATO_FECHA_BD);
            string fechaFinStr = fechaHoraFin.ToString(FORMATO_FECHA_BD);

            string nuevoIdEvento = _eventoModelo.GuardarEvento(
                nombreEvent, tipoEvent, fechaIniStr, fechaFinStr, idLider);

            if (nuevoIdEvento != null)
            {
                MessageBox.Show($"El evento '{nombreEvent}' fue registrado correctamente.",
                    "Evento registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return nuevoIdEvento;
            }
            else
            {
                // El Modelo retorna null cuando detecta solapamiento de horario.
                MessageBox.Show("No se pudo registrar el evento. El horario seleccionado ya está ocupado.",
                    "Conflicto de horario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        // Consulta los eventos futuros no deshabilitados y los retorna para mostrar en la Vista.
        public List<Evento> ConsultarEventos()
        {
            // La fecha actual se pasa como string para que el Modelo la compare directamente con la BD.
            string ahora = DateTime.Now.ToString(FORMATO_FECHA_BD);

            List<Evento> eventos = _eventoModelo.ObtenerEventos(ahora);

            if (eventos.Count == 0)
                MessageBox.Show("No hay eventos programados próximamente.",
                    "Sin eventos", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return eventos;
        }

        // Retorna los invitados que AÚN NO están inscritos en el evento dado.
        public List<Usuario> ObtenerInvitados(string idEvento)
        {
            List<Usuario> todos     = _usuarioModelo.ObtenerInvitados();
            List<Usuario> inscritos = ObtenerInscriptos(idEvento);

            // Construimos una lista de IDs ya inscritos para filtrar eficientemente.
            List<string> idsInscritos = new List<string>();
            foreach (Usuario inscrito in inscritos)
                idsInscritos.Add(inscrito.Id);

            // Devolvemos solo quienes no están en la lista de inscritos.
            List<Usuario> disponibles = new List<Usuario>();
            foreach (Usuario usuario in todos)
                if (!idsInscritos.Contains(usuario.Id))
                    disponibles.Add(usuario);

            return disponibles;
        }

        // Delega al Modelo la operación de agregar un invitado al array del evento.
        public bool AgregarInvitado(string idEvento, string idInvitado,
            string fechahoraIniEvento, string fechahoraFinEvento)
        {
            bool agregado = _eventoModelo.AgregarInvitado(
                idEvento, idInvitado, fechahoraIniEvento, fechahoraFinEvento);

            if (agregado)
            {
                MessageBox.Show("Invitado agregado correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                // El Modelo retorna false si el invitado ya está inscrito o tiene conflicto de horario.
                MessageBox.Show(
                    "No se pudo agregar el invitado. Puede que ya esté en este " +
                    "evento o tenga otro evento en el mismo horario.",
                    "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        // Obtiene los datos completos de los invitados inscritos en un evento.
        public List<Usuario> ObtenerInscriptos(string idEvento)
        {
            Evento evento = _eventoModelo.ObtenerEventoPorId(idEvento);

            if (evento == null)
                return new List<Usuario>();

            // evento.Invitados es la lista de _id; se consultan los usuarios correspondientes.
            return _usuarioModelo.ObtenerInvitadosInscriptos(evento.Invitados);
        }

        // Retorna un evento por su ID para mostrarlo o editarlo en la Vista.
        public Evento ConsultarEventoPorID(string idEvento)
        {
            return _eventoModelo.ObtenerEventoPorId(idEvento);
        }

        // Abre el formulario de actualización modal con los datos actuales del evento prellenados.
        public void AbrirFormularioActualizar(string id, int codigo, string nombre,
            string tipo, string fechaInicio, string fechaFin)
        {
            FormActualizarEvento form = new FormActualizarEvento(
                id, codigo, nombre, tipo, fechaInicio, fechaFin);
            form.ShowDialog(); // ShowDialog bloquea la ventana padre hasta que este form se cierre.
        }

        // Retorna los eventos futuros donde el invitado está inscrito (para el panel del invitado).
        public List<Evento> ObtenerEventosPorInvitado(string idUsuario)
        {
            return _eventoModelo.ObtenerEventosPorInvitado(idUsuario);
        }

        // Valida que haya un evento seleccionado, pide confirmación y lo deshabilita en la BD.
        public bool DeshabilitarEvento(string id, string nombre)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("No hay ningún evento seleccionado.",
                    "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // TryParse para validar que el string sea un ObjectId válido antes de enviarlo al Modelo.
            if (!ObjectId.TryParse(id, out ObjectId objectId))
            {
                MessageBox.Show("El ID del evento no es válido.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Confirmación del usuario antes de ejecutar la acción destructiva.
            var confirmacion = MessageBox.Show(
                $"¿Deseas deshabilitar el evento '{nombre}'?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return false;

            bool resultado = _eventoModelo.DeshabilitarEvento(objectId);

            if (resultado)
                MessageBox.Show("El evento fue deshabilitado correctamente.",
                    "Evento deshabilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo deshabilitar el evento.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return resultado;
        }

        // Valida los nuevos datos del evento y los envía al Modelo para actualizar en la BD.
        public bool ActualizarEvento(string nombreEvent, string tipoevent,
            DateTime fechaHoraIni, DateTime fechaHoraFin, ObjectId id)
        {
            if (string.IsNullOrWhiteSpace(nombreEvent) || string.IsNullOrWhiteSpace(tipoevent))
            {
                MessageBox.Show("Complete todos los campos");
                return false;
            }

            if (fechaHoraFin < fechaHoraIni)
            {
                MessageBox.Show("La fecha final no puede ser menor a la inicial");
                return false;
            }

            return _eventoModelo.ActualizarEvento(nombreEvent, tipoevent, fechaHoraIni, fechaHoraFin, id);
        }
    }
}
