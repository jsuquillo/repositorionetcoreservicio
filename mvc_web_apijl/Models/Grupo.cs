using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Grupo
    {
        public Grupo()
        {
            UsuarioGupo = new HashSet<UsuarioGupo>();
        }

        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public ICollection<UsuarioGupo> UsuarioGupo { get; set; }
    }
}
