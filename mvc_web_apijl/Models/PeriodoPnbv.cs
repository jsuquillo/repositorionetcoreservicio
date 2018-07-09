using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class PeriodoPnbv
    {
        public PeriodoPnbv()
        {
            ObjetivoPnbv = new HashSet<ObjetivoPnbv>();
        }

        public int IdPeriodoPnbv { get; set; }
        public string AnioInicio { get; set; }
        public string AnioFin { get; set; }
        public bool IsVigente { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public ICollection<ObjetivoPnbv> ObjetivoPnbv { get; set; }
    }
}
