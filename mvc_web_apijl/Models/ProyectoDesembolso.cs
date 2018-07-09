using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class ProyectoDesembolso
    {
        public int IdProyectoDesembolso { get; set; }
        public int IdProyecto { get; set; }
        public int Periodo { get; set; }
        public int? IdProyectoCooperante { get; set; }
        public int? IdProyectoContraparte { get; set; }
        public int? IdProyectoOtraAportacion { get; set; }
        public int? IdMoneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? MontoPresupuestado { get; set; }
        public decimal? MontoDesembolsado { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Proyecto IdProyectoNavigation { get; set; }
    }
}
