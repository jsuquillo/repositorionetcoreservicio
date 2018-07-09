using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class ObjetivoPnbv
    {
        public ObjetivoPnbv()
        {
            MetaPnbv = new HashSet<MetaPnbv>();
            PoliticaPnbv = new HashSet<PoliticaPnbv>();
            ProyectoPnbv = new HashSet<ProyectoPnbv>();
        }

        public int IdObjetivoPnbv { get; set; }
        public int IdPeriodoPnbv { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public PeriodoPnbv IdPeriodoPnbvNavigation { get; set; }
        public ICollection<MetaPnbv> MetaPnbv { get; set; }
        public ICollection<PoliticaPnbv> PoliticaPnbv { get; set; }
        public ICollection<ProyectoPnbv> ProyectoPnbv { get; set; }
    }
}
