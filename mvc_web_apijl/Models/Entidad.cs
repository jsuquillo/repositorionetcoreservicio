using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Entidad
    {
        public int IdEntidad { get; set; }
        public int IdPais { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Logo { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Pais IdPaisNavigation { get; set; }
    }
}
