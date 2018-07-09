using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Rol
    {
        public Rol()
        {
            FuncionalidadRol = new HashSet<FuncionalidadRol>();
            UsuarioRol = new HashSet<UsuarioRol>();
        }

        public int IdRol { get; set; }
        public int? IdGrupoRol { get; set; }
        public int IdSistema { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsAcivo { get; set; }

        public Gruporol IdGrupoRolNavigation { get; set; }
        public Sistema IdSistemaNavigation { get; set; }
        public ICollection<FuncionalidadRol> FuncionalidadRol { get; set; }
        public ICollection<UsuarioRol> UsuarioRol { get; set; }
    }
}
