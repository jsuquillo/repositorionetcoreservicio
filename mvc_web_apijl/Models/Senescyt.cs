using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Senescyt
    {
        public int SncId { get; set; }
        public int DpId { get; set; }
        public string SncNombreTitCiudadano { get; set; }
        public string SncCodRegTitCiudadano { get; set; }
        public DateTime SncFechaRegTitCiudadano { get; set; }
        public string SncNombreIes { get; set; }
        public string SncTipo { get; set; }
        public string SncAreaEstudio { get; set; }
        public short? SncAreaCodigo { get; set; }
        public string SncSubareaEstudio { get; set; }
        public short? SncSubareaCodigo { get; set; }
        public bool SncIsActivo { get; set; }

        public DatosPrincipales1 Dp { get; set; }
    }
}
