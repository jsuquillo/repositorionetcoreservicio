using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class ProyectoContraparte
    {
        public int IdProyectoContraparte { get; set; }
        public int IdProyecto { get; set; }
        public int IdContraparte { get; set; }
        public decimal? Monto { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Proyecto IdProyectoNavigation { get; set; }
    }
}
