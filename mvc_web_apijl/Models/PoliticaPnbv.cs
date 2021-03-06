﻿using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class PoliticaPnbv
    {
        public PoliticaPnbv()
        {
            LineamientoPnbv = new HashSet<LineamientoPnbv>();
            ProyectoPnbv = new HashSet<ProyectoPnbv>();
        }

        public int IdPoliticaPnbv { get; set; }
        public int IdObjetivoPnbv { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public ObjetivoPnbv IdObjetivoPnbvNavigation { get; set; }
        public ICollection<LineamientoPnbv> LineamientoPnbv { get; set; }
        public ICollection<ProyectoPnbv> ProyectoPnbv { get; set; }
    }
}
