using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class RegistroPropiedad1
    {
        public int RpId { get; set; }
        public int DpId { get; set; }
        public string RpTipoContrato { get; set; }
        public string RpContraparte { get; set; }
        public DateTime RpFechaInscripcion { get; set; }
        public string RpClaveCatastral { get; set; }
        public string RpParroquia { get; set; }
        public string RpCanton { get; set; }
        public string RpCuantia { get; set; }
        public string RpUbicacion { get; set; }
        public bool RpIsActivo { get; set; }

        public DatosPrincipales Dp { get; set; }
    }
}
