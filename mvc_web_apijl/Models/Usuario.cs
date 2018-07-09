using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Detalleusuario = new HashSet<Detalleusuario>();
            UsuarioGupo = new HashSet<UsuarioGupo>();
            UsuarioRol = new HashSet<UsuarioRol>();
            UsuarioSistema = new HashSet<UsuarioSistema>();
        }

        public int IdUsuario { get; set; }
        public int IdUnidadAdministrativa { get; set; }
        public bool IsInterno { get; set; }
        public string Cuenta { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public short Estado { get; set; }
        public short? Intentos { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public Unidadadministrativa IdUnidadAdministrativaNavigation { get; set; }
        public ICollection<Detalleusuario> Detalleusuario { get; set; }
        public ICollection<UsuarioGupo> UsuarioGupo { get; set; }
        public ICollection<UsuarioRol> UsuarioRol { get; set; }
        public ICollection<UsuarioSistema> UsuarioSistema { get; set; }
    }
}
