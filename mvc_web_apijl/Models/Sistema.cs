using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Sistema
    {
        public Sistema()
        {
            Rol = new HashSet<Rol>();
            UsuarioSistema = new HashSet<UsuarioSistema>();
        }

        public int IdSistema { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool IsInterno { get; set; }
        public string Siglas { get; set; }
        public string Url { get; set; }
        public byte[] Logo { get; set; }
        public string Ambiente { get; set; }
        public string Servidor { get; set; }
        public string Puerto { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public ICollection<Rol> Rol { get; set; }
        public ICollection<UsuarioSistema> UsuarioSistema { get; set; }
    }
}
