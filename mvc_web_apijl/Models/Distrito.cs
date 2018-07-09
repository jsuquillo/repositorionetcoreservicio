using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Distrito
    {
        public Distrito()
        {
            Circuito = new HashSet<Circuito>();
        }

        public int IdDistrito { get; set; }
        public int IdZona { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Zona IdZonaNavigation { get; set; }
        public ICollection<Circuito> Circuito { get; set; }
    }
}
