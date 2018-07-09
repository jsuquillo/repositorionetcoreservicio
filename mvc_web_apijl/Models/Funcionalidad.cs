using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Funcionalidad
    {
        public Funcionalidad()
        {
            FuncionalidadGruporol = new HashSet<FuncionalidadGruporol>();
            FuncionalidadRol = new HashSet<FuncionalidadRol>();
            InverseIdPadreNavigation = new HashSet<Funcionalidad>();
        }

        public int IdFuncionalidad { get; set; }
        public int? IdPadre { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public short? Orden { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public Funcionalidad IdPadreNavigation { get; set; }
        public ICollection<FuncionalidadGruporol> FuncionalidadGruporol { get; set; }
        public ICollection<FuncionalidadRol> FuncionalidadRol { get; set; }
        public ICollection<Funcionalidad> InverseIdPadreNavigation { get; set; }
    }
}
