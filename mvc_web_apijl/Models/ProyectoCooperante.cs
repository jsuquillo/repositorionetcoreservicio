using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class ProyectoCooperante
    {
        public int IdProyectoCooperante { get; set; }
        public int IdProyecto { get; set; }
        public int IdCooperante { get; set; }
        public bool? IsPrincipal { get; set; }
        public decimal? Monto { get; set; }
        public decimal? TipoCambio { get; set; }
        public int IdMoneda { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Proyecto IdProyectoNavigation { get; set; }
    }
}
