using System;
using System.Collections.Generic;

namespace src.Modelo
{
    public class Evento
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string LiderId { get; set; }
        public List<string> InvitadosIds { get; set; }
        public bool Activo { get; set; }
    }
}
