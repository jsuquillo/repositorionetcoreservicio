using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class SuperciasAccionistas1
    {
        public int ComAccionistaId { get; set; }
        public int ComId { get; set; }
        public string ComAccionistaNombreEmpresa { get; set; }
        public string ComAccionistaRucAccionista { get; set; }
        public string ComAccionistaTipoInversion { get; set; }
        public decimal? ComAccionistaValorAccion { get; set; }
        public bool ComAccionistaIsActivo { get; set; }

        public Supercias Com { get; set; }
    }
}
