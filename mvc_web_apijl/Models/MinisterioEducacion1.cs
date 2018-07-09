using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class MinisterioEducacion1
    {
        public int EduId { get; set; }
        public int DpId { get; set; }
        public string EduInstitucionEducativa { get; set; }
        public string EduTipoTituloOtorgadoIe { get; set; }
        public string EduNumeroRefrendacionTitulo { get; set; }
        public int EduCodigoRefrendacionTitulo { get; set; }
        public bool EduIsActivo { get; set; }

        public DatosPrincipales1 Dp { get; set; }
    }
}
