using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class SriEstadosTributarios
    {
        public int SriEstTributarioId { get; set; }
        public int SriRucId { get; set; }
        public string SriEstTributarioEstado { get; set; }
        public string SriEstTributarioDescripcion { get; set; }
        public string SriEstTributarioMotivo { get; set; }
        public bool SriEstTributarioIsActivo { get; set; }

        public Sri SriRuc { get; set; }
    }
}
