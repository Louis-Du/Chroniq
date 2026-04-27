// ============================================================
//  CAPA: MODELO  →  Archivo: Evento.cs
// ============================================================
//  ENTIDAD: Representa un documento de la colección "Eventos"
//  en MongoDB. Cada propiedad mapea exactamente un campo
//  de la BD usando [BsonElement].
//
//  Estructura real en MongoDB (confirmada en las imágenes):
//  {
//    codigoEvent      : 11111
//    nombreEvent      : "dia de la independencia"
//    creadoPor        : ObjectId("69eb9cce5a559489d78a42d2")
//    tipoevent        : "Cultural"
//    fechahoraIniEvent: "2026-05-15 09:30:00"
//    fechahoraFinEvent: "2026-05-15 14:00:00"
//    invitados        : []
//  }
//
//  IMPORTANTE: fechahoraIniEvent y fechahoraFinEvent son string
//  en la BD, NO DateTime. El Controlador hace la conversión
//  antes de enviárselos al Modelo (EventoControlador.cs).
//
//  ¿Quién usa esta clase?
//  → EventoModelo.cs la usa para mapear los documentos de MongoDB.
//  → El Controlador la recibe como resultado de las consultas.
//  La Vista nunca instancia esta clase directamente.
// ============================================================

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace src.Modelo
{
    public class Evento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // Código numérico del evento. Campo: codigoEvent
        [BsonElement("codigoEvent")]
        public int CodigoEvent { get; set; }

        // Nombre del evento. Campo: nombreEvent
        [BsonElement("nombreEvent")]
        public string NombreEvent { get; set; }

        // ObjectId del líder que creó el evento. Campo: creadoPor
        // Se guarda como ObjectId en MongoDB.
        [BsonElement("creadoPor")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string CreadoPor { get; set; }

        // Tipo de evento (Cultural, Deportivo, etc.). Campo: tipoevent
        [BsonElement("tipoevent")]
        public string TipoEvent { get; set; }

        // Fecha y hora de inicio como string. Campo: fechahoraIniEvent
        // Formato: "yyyy-MM-dd HH:mm:ss"  Ej: "2026-05-15 09:30:00"
        // NO es DateTime porque la BD lo almacena como texto.
        [BsonElement("fechahoraIniEvent")]
        public string FechahoraIniEvent { get; set; }

        // Fecha y hora de fin como string. Campo: fechahoraFinEvent
        // Formato: "yyyy-MM-dd HH:mm:ss"  Ej: "2026-05-15 14:00:00"
        [BsonElement("fechahoraFinEvent")]
        public string FechahoraFinEvent { get; set; }

        // Lista de ObjectIds de los invitados agregados al evento.
        // Campo: invitados. Empieza vacío al crear el evento (HU-02)
        // y se llena en HU-05 (agregar invitados).
        [BsonElement("invitados")]
        public List<string> Invitados { get; set; } = new List<string>();
    }
}
