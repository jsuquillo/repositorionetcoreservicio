using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Proyecto
    {
        public Proyecto()
        {
            ProyectoBeneficiario = new HashSet<ProyectoBeneficiario>();
            ProyectoContraparte = new HashSet<ProyectoContraparte>();
            ProyectoCooperante = new HashSet<ProyectoCooperante>();
            ProyectoDesembolso = new HashSet<ProyectoDesembolso>();
            ProyectoEntidad = new HashSet<ProyectoEntidad>();
            ProyectoModalidadCooperacion = new HashSet<ProyectoModalidadCooperacion>();
            ProyectoObservacion = new HashSet<ProyectoObservacion>();
            ProyectoOtraAportacion = new HashSet<ProyectoOtraAportacion>();
            ProyectoPdot = new HashSet<ProyectoPdot>();
            ProyectoPnbv = new HashSet<ProyectoPnbv>();
            ProyectoSubsectorSenplades = new HashSet<ProyectoSubsectorSenplades>();
            ProyectoUbicacion = new HashSet<ProyectoUbicacion>();
        }

        public int IdProyecto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ObjetivoGeneral { get; set; }
        public string ObjetivoEspecifico { get; set; }
        public string OtrasInstituciones { get; set; }
        public string IdPais { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public int IdEstado { get; set; }
        public int IdFuenteCooperacion { get; set; }
        public int? IdPrograma { get; set; }
        public decimal? AvanceEjecucionFisica { get; set; }
        public decimal? AvanceEjecucionPresupuestaria { get; set; }
        public int? IdCertificacion { get; set; }
        public DateTime? FechaCertificacion { get; set; }
        public string Observaciones { get; set; }
        public bool? Isactivo { get; set; }
        public int? UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public int? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }

        public Programa IdProgramaNavigation { get; set; }
        public ICollection<ProyectoBeneficiario> ProyectoBeneficiario { get; set; }
        public ICollection<ProyectoContraparte> ProyectoContraparte { get; set; }
        public ICollection<ProyectoCooperante> ProyectoCooperante { get; set; }
        public ICollection<ProyectoDesembolso> ProyectoDesembolso { get; set; }
        public ICollection<ProyectoEntidad> ProyectoEntidad { get; set; }
        public ICollection<ProyectoModalidadCooperacion> ProyectoModalidadCooperacion { get; set; }
        public ICollection<ProyectoObservacion> ProyectoObservacion { get; set; }
        public ICollection<ProyectoOtraAportacion> ProyectoOtraAportacion { get; set; }
        public ICollection<ProyectoPdot> ProyectoPdot { get; set; }
        public ICollection<ProyectoPnbv> ProyectoPnbv { get; set; }
        public ICollection<ProyectoSubsectorSenplades> ProyectoSubsectorSenplades { get; set; }
        public ICollection<ProyectoUbicacion> ProyectoUbicacion { get; set; }
    }
}
