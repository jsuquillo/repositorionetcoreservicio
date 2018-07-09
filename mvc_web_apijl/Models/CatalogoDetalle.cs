using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class CatalogoDetalle
    {
        public int IdCatalogoDetalle { get; set; }
        public int IdCatalogo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Catalogo IdCatalogoNavigation { get; set; }
    }
}
