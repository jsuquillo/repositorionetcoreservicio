using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Unidadadministrativa
    {
        public Unidadadministrativa()
        {
            InverseIdPadreNavigation = new HashSet<Unidadadministrativa>();
            Usuario = new HashSet<Usuario>();
        }

        public int IdUnidadAdministrativa { get; set; }
        public int? IdPadre { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public int IdContinente { get; set; }
        public int IdPais { get; set; }
        public int IdRegion { get; set; }
        public int IdProvincia { get; set; }
        public int IdCiudad { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public Unidadadministrativa IdPadreNavigation { get; set; }
        public ICollection<Unidadadministrativa> InverseIdPadreNavigation { get; set; }
        public ICollection<Usuario> Usuario { get; set; }
    }
}
