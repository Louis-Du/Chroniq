using src.Modelo;

namespace src.Controlador
{
    public class EventoControlador
    {
        public bool PuedeCrearEvento(Evento evento)
        {
            return evento != null && evento.Activo;
        }
    }
}
