using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Cne1
    {
        public string CneCodigoElectoral { get; set; }
        public int DpId { get; set; }
        public string CneProvincia { get; set; }
        public string CneCanton { get; set; }
        public string CneParroquia { get; set; }
        public bool CneHabilitadoTramitePublico { get; set; }
        public string CneRecinto { get; set; }
        public bool CneIsActivo { get; set; }

        public DatosPrincipales Dp { get; set; }
    }
}
