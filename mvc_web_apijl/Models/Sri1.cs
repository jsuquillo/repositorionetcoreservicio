using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Sri1
    {
        public Sri1()
        {
            SriEstablecimientos = new HashSet<SriEstablecimientos>();
            SriEstadosTributarios1 = new HashSet<SriEstadosTributarios1>();
        }

        public int SriRucId { get; set; }
        public int DpId { get; set; }
        public string SriRucRazonSocial { get; set; }
        public string SriRucFantasiaComercial { get; set; }
        public string SriRucTipoPersona { get; set; }
        public DateTime SriRucFechaInicioActividad { get; set; }
        public DateTime? SriRucFechaCancelacion { get; set; }
        public DateTime? SriRucFechaSuspDef { get; set; }
        public DateTime? SriRucFechaReiActividad { get; set; }
        public string SriRucActEcoPrincipal { get; set; }
        public string SriRucClaseContibuyente { get; set; }
        public string SriRucEstadoRucPerNat { get; set; }
        public string SriRucEstadoRucSociedad { get; set; }
        public string SriRucTipoContribuyente { get; set; }
        public DateTime? SriRucFechaActualizacion { get; set; }
        public string SriRucEstadoContribuyente { get; set; }
        public short? SriTipoContribId { get; set; }
        public string SriTipoContribeNivel1 { get; set; }
        public string SriTipoContribNivel2 { get; set; }
        public string SriTipoContribNivel3 { get; set; }
        public string SriTipoContribNivel4 { get; set; }
        public string SriTipoContribUltNivel { get; set; }
        public string SriActEcoActGeneral { get; set; }
        public string SriActEcoCod { get; set; }
        public string SriActEcoCodN1Fam { get; set; }
        public string SriActEcoDescN1Fam { get; set; }
        public string SriActEcoCodN2Grp { get; set; }
        public string SriActEcoDescN2Grp { get; set; }
        public string SriActEcoCodN3Subgrp { get; set; }
        public string SriActEcoDescN3Subgrp { get; set; }
        public string SriActEcoCodN4Clase { get; set; }
        public string SriActEcoDescN4Clase { get; set; }
        public string SriActEcoCodN5Subgrp { get; set; }
        public string SriActEcoDescN5Subgrp { get; set; }
        public string SriActEcoCodN6Act { get; set; }
        public string SriActEcoDescN6Act { get; set; }
        public string SriEstrOrgCodigoProvincia { get; set; }
        public string SriEstrOrgCodigoRegion { get; set; }
        public short SriEstrOrgIdentificacion { get; set; }
        public string SriEstrOrgNombreProvincia { get; set; }
        public string SriEstrOrgNombreRegion { get; set; }
        public bool SriIsActivo { get; set; }

        public DatosPrincipales Dp { get; set; }
        public ICollection<SriEstablecimientos> SriEstablecimientos { get; set; }
        public ICollection<SriEstadosTributarios1> SriEstadosTributarios1 { get; set; }
    }
}
