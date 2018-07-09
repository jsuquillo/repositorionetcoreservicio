using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class SuperciasAdministradores1
    {
        public int ComAdminId { get; set; }
        public int ComId { get; set; }
        public string ComAdminNombreCompania { get; set; }
        public string ComAdminRuc { get; set; }
        public string ComAdminCargo { get; set; }
        public DateTime? ComAdminFechaNombramiento { get; set; }
        public DateTime? ComAdminFechaVencimiento { get; set; }
        public string ComAdminPeriodo { get; set; }
        public DateTime? ComAdminFechaInscRegMer { get; set; }
        public string ComAdminNumRegistroRegMer { get; set; }
        public string ComAdminCedulaAdministrador { get; set; }
        public string ComAdminNombreAdministrador { get; set; }
        public string ComAdminCodigoCargo { get; set; }
        public string ComAdminRepresentanteLegal { get; set; }
        public bool ComAdminIsActivo { get; set; }

        public Supercias1 Com { get; set; }
    }
}
