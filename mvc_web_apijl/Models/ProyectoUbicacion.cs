using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class ProyectoUbicacion
    {
        public int IdProyectoUbicacion { get; set; }
        public int IdProyecto { get; set; }
        public bool? IsNacional { get; set; }
        public int? IdProvincia { get; set; }
        public int? IdCanton { get; set; }
        public int? IdParroquia { get; set; }
        public string CoordenadasUtmx { get; set; }
        public string CoordenadasUtmy { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public CiudadCanton IdCantonNavigation { get; set; }
        public Parroquia IdParroquiaNavigation { get; set; }
        public EstadoProvincia IdProvinciaNavigation { get; set; }
        public Proyecto IdProyectoNavigation { get; set; }
    }
}
