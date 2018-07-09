using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class RmSocietarios
    {
        public int RmActSocId { get; set; }
        public int DpId { get; set; }
        public string RmActSocNombreCompania { get; set; }
        public string RmActSocRuc { get; set; }
        public string RmActSocTipoCompania { get; set; }
        public DateTime? RmActSocFechaInscripcion { get; set; }
        public string RmActSocApellidosAdmin { get; set; }
        public string RmActSocNombresAdmin { get; set; }
        public string RmActSocCedulaAdmin { get; set; }
        public string RmActSocCargo { get; set; }
        public DateTime? RmActSocFechaEscritura { get; set; }
        public string RmActSocNotaria { get; set; }
        public bool RmActSocIsActivo { get; set; }

        public DatosPrincipales1 Dp { get; set; }
    }
}
