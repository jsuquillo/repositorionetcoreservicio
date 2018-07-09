using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class EstadoProvincia
    {
        public EstadoProvincia()
        {
            CiudadCanton = new HashSet<CiudadCanton>();
            ProyectoUbicacion = new HashSet<ProyectoUbicacion>();
        }

        public int IdProvincia { get; set; }
        public int IdRegion { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public int? IdPais { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Pais IdPaisNavigation { get; set; }
        public ICollection<CiudadCanton> CiudadCanton { get; set; }
        public ICollection<ProyectoUbicacion> ProyectoUbicacion { get; set; }
    }
}
