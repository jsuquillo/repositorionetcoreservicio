using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class ProyectoPnbv
    {
        public int IdProyectoPnbv { get; set; }
        public int IdProyecto { get; set; }
        public int? IdObjetivo { get; set; }
        public int? IdPolitica { get; set; }
        public int? IdMeta { get; set; }
        public int? IdLineamiento { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public LineamientoPnbv IdLineamientoNavigation { get; set; }
        public MetaPnbv IdMetaNavigation { get; set; }
        public ObjetivoPnbv IdObjetivoNavigation { get; set; }
        public PoliticaPnbv IdPoliticaNavigation { get; set; }
        public Proyecto IdProyectoNavigation { get; set; }
    }
}
