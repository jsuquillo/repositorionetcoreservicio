using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class UsuarioSistema
    {
        public int IdUsuarioSistema { get; set; }
        public int IdUsuario { get; set; }
        public int IdSistema { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public Sistema IdSistemaNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
    }
}
