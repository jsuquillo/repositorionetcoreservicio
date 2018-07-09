using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Parroquia
    {
        public Parroquia()
        {
            ProyectoUbicacion = new HashSet<ProyectoUbicacion>();
        }

        public int IdParroquia { get; set; }
        public int IdCanton { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public CiudadCanton IdCantonNavigation { get; set; }
        public ICollection<ProyectoUbicacion> ProyectoUbicacion { get; set; }
    }
}
