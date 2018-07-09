using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class RmContratos1
    {
        public int RmcId { get; set; }
        public int DpId { get; set; }
        public string RmcActMerRegiTipoContrato { get; set; }
        public DateTime? RmcActMerRegFechaInscr { get; set; }
        public int? RmcActMerRegNumeroInscr { get; set; }
        public string RmcActMerRegCompania { get; set; }
        public string RmcActMerRegRepresentante { get; set; }
        public string RmcResDomPrenChasisOSerie { get; set; }
        public string RmcResDomPrenPlaca { get; set; }
        public string RmcResDomPrenMotor { get; set; }
        public string RmcResDomPrenMarca { get; set; }
        public string RmcResDomPrenModelo { get; set; }
        public int? RmcResDomPrenAnioFabr { get; set; }
        public bool RmcIsActivo { get; set; }

        public DatosPrincipales Dp { get; set; }
    }
}
