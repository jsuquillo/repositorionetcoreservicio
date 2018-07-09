using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class CiudadCanton
    {
        public CiudadCanton()
        {
            Parroquia = new HashSet<Parroquia>();
            ProyectoUbicacion = new HashSet<ProyectoUbicacion>();
        }

        public int IdCanton { get; set; }
        public int IdProvincia { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public int? IdPais { get; set; }
        public int? TmpIdMigracion { get; set; }

        public EstadoProvincia IdProvinciaNavigation { get; set; }
        public ICollection<Parroquia> Parroquia { get; set; }
        public ICollection<ProyectoUbicacion> ProyectoUbicacion { get; set; }
    }
}
