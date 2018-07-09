using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class FuncionalidadRol
    {
        public int IdFuncionalidadRol { get; set; }
        public int IdFuncionalidad { get; set; }
        public int IdRol { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public Funcionalidad IdFuncionalidadNavigation { get; set; }
        public Rol IdRolNavigation { get; set; }
    }
}
