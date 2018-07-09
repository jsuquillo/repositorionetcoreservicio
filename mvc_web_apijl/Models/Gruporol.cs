using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Gruporol
    {
        public Gruporol()
        {
            FuncionalidadGruporol = new HashSet<FuncionalidadGruporol>();
            Rol = new HashSet<Rol>();
        }

        public int IdGrupoRol { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsAcivo { get; set; }

        public ICollection<FuncionalidadGruporol> FuncionalidadGruporol { get; set; }
        public ICollection<Rol> Rol { get; set; }
    }
}
