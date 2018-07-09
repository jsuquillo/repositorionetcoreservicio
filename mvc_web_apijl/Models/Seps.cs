﻿using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Seps
    {
        public int SepId { get; set; }
        public int DpId { get; set; }
        public string SepNombreRepresentanteLegal { get; set; }
        public string SepNombreSecretario { get; set; }
        public string SepClaseOrganizacion { get; set; }
        public string SepEstadoOrganizacion { get; set; }
        public DateTime? SepFechaRegistro { get; set; }
        public string SepInterseccion { get; set; }
        public string SepCalle { get; set; }
        public string SepCanton { get; set; }
        public int? SepNumero { get; set; }
        public int? SepNumeroResolucion { get; set; }
        public string SepParroquia { get; set; }
        public string SepProvincia { get; set; }
        public string SepRazonSocial { get; set; }
        public string SepTipoOrganizacion { get; set; }
        public bool SepIsActivo { get; set; }

        public DatosPrincipales1 Dp { get; set; }
    }
}
