using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Jnda
    {
        public int JndId { get; set; }
        public int DpId { get; set; }
        public string JndCallePrincipalLocCom { get; set; }
        public string JndCallePrincipalTaller { get; set; }
        public string JndCantonLocCom { get; set; }
        public string JndCantonTaller { get; set; }
        public string JndEdificioLocCom { get; set; }
        public string JndEdificioTaller { get; set; }
        public string JndInterseccionLocCom { get; set; }
        public string JndInterseccionDelTaller { get; set; }
        public string JndNumCasaLocCom { get; set; }
        public string JndNumCasaTaller { get; set; }
        public string JndNombreRamaArtesanal { get; set; }
        public string JndNumCalificacion { get; set; }
        public string JndParroquiaLocCom { get; set; }
        public string JndParroquiaTaller { get; set; }
        public string JndPisoLocCom { get; set; }
        public string JndPisoTaller { get; set; }
        public bool JndIsActivo { get; set; }

        public DatosPrincipales Dp { get; set; }
    }
}
