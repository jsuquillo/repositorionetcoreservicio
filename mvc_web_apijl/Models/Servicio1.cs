using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Servicio1
    {
        public Servicio1()
        {
            DatosPrincipales = new HashSet<DatosPrincipales>();
        }

        public short WsCodigo { get; set; }
        public string WsInstitucion { get; set; }
        public string WsNombre { get; set; }
        public string WsUrl { get; set; }
        public short WsVersion { get; set; }
        public bool WsIsActivo { get; set; }

        public ICollection<DatosPrincipales> DatosPrincipales { get; set; }
    }
}
