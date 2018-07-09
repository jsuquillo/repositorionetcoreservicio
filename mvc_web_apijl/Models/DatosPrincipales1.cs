using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class DatosPrincipales1
    {
        public DatosPrincipales1()
        {
            Ant1 = new HashSet<Ant1>();
            Cne = new HashSet<Cne>();
            Jnda1 = new HashSet<Jnda1>();
            MinisterioEducacion1 = new HashSet<MinisterioEducacion1>();
            RegistroCivil1 = new HashSet<RegistroCivil1>();
            RegistroPropiedad = new HashSet<RegistroPropiedad>();
            RmContratos = new HashSet<RmContratos>();
            RmSocietarios = new HashSet<RmSocietarios>();
            SecapCursos = new HashSet<SecapCursos>();
            Senescyt = new HashSet<Senescyt>();
            Seps = new HashSet<Seps>();
            Sri = new HashSet<Sri>();
            Supercias1 = new HashSet<Supercias1>();
        }

        public int DpId { get; set; }
        public short WsCodigo { get; set; }
        public string DpDocumento { get; set; }
        public string DpTipoDocumento { get; set; }
        public string DpNombres { get; set; }
        public string DpRazonSocial { get; set; }
        public string DpEmail { get; set; }
        public bool DpIsActivo { get; set; }

        public Servicio WsCodigoNavigation { get; set; }
        public ICollection<Ant1> Ant1 { get; set; }
        public ICollection<Cne> Cne { get; set; }
        public ICollection<Jnda1> Jnda1 { get; set; }
        public ICollection<MinisterioEducacion1> MinisterioEducacion1 { get; set; }
        public ICollection<RegistroCivil1> RegistroCivil1 { get; set; }
        public ICollection<RegistroPropiedad> RegistroPropiedad { get; set; }
        public ICollection<RmContratos> RmContratos { get; set; }
        public ICollection<RmSocietarios> RmSocietarios { get; set; }
        public ICollection<SecapCursos> SecapCursos { get; set; }
        public ICollection<Senescyt> Senescyt { get; set; }
        public ICollection<Seps> Seps { get; set; }
        public ICollection<Sri> Sri { get; set; }
        public ICollection<Supercias1> Supercias1 { get; set; }
    }
}
