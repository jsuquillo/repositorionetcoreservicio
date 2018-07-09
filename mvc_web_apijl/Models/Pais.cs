using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Pais
    {
        public Pais()
        {
            Entidad = new HashSet<Entidad>();
            EstadoProvincia = new HashSet<EstadoProvincia>();
        }

        public int IdPais { get; set; }
        public string Codigo { get; set; }
        public int? IdContinente { get; set; }
        public string NombreCorto { get; set; }
        public string Bandera { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string NombreOficial { get; set; }
        public int? IdCodigoInternacional { get; set; }
        public int? TmpIdMigracion { get; set; }
        public int? IdTipo { get; set; }

        public Continente IdContinenteNavigation { get; set; }
        public ICollection<Entidad> Entidad { get; set; }
        public ICollection<EstadoProvincia> EstadoProvincia { get; set; }
    }
}
