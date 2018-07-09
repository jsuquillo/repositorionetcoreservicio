using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Detalleusuario
    {
        public int IdDetalleUsuario { get; set; }
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public int UsuarioCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public bool IsActivo { get; set; }

        public Usuario IdUsuarioNavigation { get; set; }
    }
}
