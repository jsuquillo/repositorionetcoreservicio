using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class SectorSenplades
    {
        public SectorSenplades()
        {
            SubsectorSenplades = new HashSet<SubsectorSenplades>();
        }

        public int IdSectorSenplades { get; set; }
        public int IdMacrosectorSenplades { get; set; }
        public string Nombre { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public MacrosectorSenplades IdMacrosectorSenpladesNavigation { get; set; }
        public ICollection<SubsectorSenplades> SubsectorSenplades { get; set; }
    }
}
