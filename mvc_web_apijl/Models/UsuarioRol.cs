using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class UsuarioRol
    {
        public int IdUsuarioRol { get; set; }
        public int IdRol { get; set; }
        public int IdUsuario { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public Rol IdRolNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
    }
}
