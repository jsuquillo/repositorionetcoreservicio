using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class RegistroCivil
    {
        public int RcId { get; set; }
        public int DpId { get; set; }
        public string RcLugarNacimiento { get; set; }
        public DateTime RcFechaNacimiento { get; set; }
        public string RcLugarInscripcionNacimiento { get; set; }
        public short RcAnioInscripcionNacimiento { get; set; }
        public string RcEstadoCivil { get; set; }
        public string RcNombreApellidoConyuge { get; set; }
        public string RcNumeroCedulaConyuge { get; set; }
        public short? RcActaMatrimonio { get; set; }
        public string RcProfesion { get; set; }
        public DateTime? RcFechaExpedicionCedula { get; set; }
        public DateTime? RcFechaExpiracionCedula { get; set; }
        public string RcCondicionCedulado { get; set; }
        public DateTime? RcFechaDefuncion { get; set; }
        public DateTime? RcFechaInscripcionDefuncion { get; set; }
        public short? RcActaDefuncion { get; set; }
        public bool RcIsActivo { get; set; }
        public string RcLugarFallecimiento { get; set; }

        public DatosPrincipales Dp { get; set; }
    }
}
