using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class DatosPrincipales
    {
        public DatosPrincipales()
        {
            Ant = new HashSet<Ant>();
            Cne1 = new HashSet<Cne1>();
            Jnda = new HashSet<Jnda>();
            MinisterioEducacion = new HashSet<MinisterioEducacion>();
            RegistroCivil = new HashSet<RegistroCivil>();
            RegistroPropiedad1 = new HashSet<RegistroPropiedad1>();
            RmContratos1 = new HashSet<RmContratos1>();
            RmSocietarios1 = new HashSet<RmSocietarios1>();
            SecapCursos1 = new HashSet<SecapCursos1>();
            Senescyt1 = new HashSet<Senescyt1>();
            Seps1 = new HashSet<Seps1>();
            Sri1 = new HashSet<Sri1>();
            Supercias = new HashSet<Supercias>();
        }

        public int DpId { get; set; }
        public short WsCodigo { get; set; }
        public string DpDocumento { get; set; }
        public string DpTipoDocumento { get; set; }
        public string DpNombres { get; set; }
        public string DpRazonSocial { get; set; }
        public string DpEmail { get; set; }
        public bool DpIsActivo { get; set; }

        public Servicio1 WsCodigoNavigation { get; set; }
        public ICollection<Ant> Ant { get; set; }
        public ICollection<Cne1> Cne1 { get; set; }
        public ICollection<Jnda> Jnda { get; set; }
        public ICollection<MinisterioEducacion> MinisterioEducacion { get; set; }
        public ICollection<RegistroCivil> RegistroCivil { get; set; }
        public ICollection<RegistroPropiedad1> RegistroPropiedad1 { get; set; }
        public ICollection<RmContratos1> RmContratos1 { get; set; }
        public ICollection<RmSocietarios1> RmSocietarios1 { get; set; }
        public ICollection<SecapCursos1> SecapCursos1 { get; set; }
        public ICollection<Senescyt1> Senescyt1 { get; set; }
        public ICollection<Seps1> Seps1 { get; set; }
        public ICollection<Sri1> Sri1 { get; set; }
        public ICollection<Supercias> Supercias { get; set; }
    }
}
