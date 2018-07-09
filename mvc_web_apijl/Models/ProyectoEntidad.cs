using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class ProyectoEntidad
    {
        public int IdProyectoEntidad { get; set; }
        public int IdProyecto { get; set; }
        public int IdEntidad { get; set; }
        public int IdTipo { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Proyecto IdProyectoNavigation { get; set; }
    }
}
