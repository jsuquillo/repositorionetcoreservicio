using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class SecapCursos1
    {
        public int SecId { get; set; }
        public int DpId { get; set; }
        public string SecArea { get; set; }
        public short? SecDuracionDias { get; set; }
        public short SecDuracionHoras { get; set; }
        public string SecEstadoAcademico { get; set; }
        public DateTime SecFechaFin { get; set; }
        public DateTime SecFechaInicio { get; set; }
        public DateTime SecFechaInscripcion { get; set; }
        public string SecLugarEjecucion { get; set; }
        public string SecModalidad { get; set; }
        public string SecNombre { get; set; }
        public string SecProcesoFormativo { get; set; }
        public string SecSectorEconomico { get; set; }
        public string SecTipoCertificado { get; set; }
        public short SecValor { get; set; }
        public bool SecIsActivo { get; set; }

        public DatosPrincipales Dp { get; set; }
    }
}
