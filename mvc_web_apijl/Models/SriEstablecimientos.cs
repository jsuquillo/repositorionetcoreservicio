using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class SriEstablecimientos
    {
        public int SriEstId { get; set; }
        public int SriRucId { get; set; }
        public string SriEstRuc { get; set; }
        public short SriEstNumero { get; set; }
        public string SriEstFantasiaComercial { get; set; }
        public string SriEstTipo { get; set; }
        public string SriEstActividadEconomica { get; set; }
        public string SriEstEstado { get; set; }
        public string SriEstUbicacionGeografica { get; set; }
        public string SriEstCalle { get; set; }
        public string SriEstInterseccion { get; set; }
        public string SriEstDireccionNumero { get; set; }
        public bool SriEstIsActivo { get; set; }

        public Sri1 SriRuc { get; set; }
    }
}
