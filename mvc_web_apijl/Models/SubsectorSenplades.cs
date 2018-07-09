using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class SubsectorSenplades
    {
        public SubsectorSenplades()
        {
            ProyectoSubsectorSenplades = new HashSet<ProyectoSubsectorSenplades>();
        }

        public int IdSubsectorSenplades { get; set; }
        public int IdSectorSenplades { get; set; }
        public string Nombre { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsMatrizProductiva { get; set; }

        public SectorSenplades IdSectorSenpladesNavigation { get; set; }
        public ICollection<ProyectoSubsectorSenplades> ProyectoSubsectorSenplades { get; set; }
    }
}
