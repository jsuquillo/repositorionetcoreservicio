using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Supercias
    {
        public Supercias()
        {
            SuperciasAccionistas1 = new HashSet<SuperciasAccionistas1>();
            SuperciasAdministradores = new HashSet<SuperciasAdministradores>();
        }

        public int ComId { get; set; }
        public int DpId { get; set; }
        public string ComCiaId { get; set; }
        public string ComCiaNombre { get; set; }
        public DateTime? ComCiaFechaConstitucion { get; set; }
        public string ComCiaPaisOrigen { get; set; }
        public string ComCiaCiudadLegal { get; set; }
        public string ComCiaCantonLegal { get; set; }
        public string ComCiaProvinciaLegal { get; set; }
        public string ComCiaCallePostal { get; set; }
        public string ComCiaNumeroCallePostal { get; set; }
        public int? ComCiaApartadoPostal { get; set; }
        public string ComCiaProvinciaPostal { get; set; }
        public string ComCiaCantonPostal { get; set; }
        public string ComCiaCiudadPostal { get; set; }
        public string ComCiaInterseccion { get; set; }
        public string ComCiaPisoDepartamento { get; set; }
        public string ComCiaEdificio { get; set; }
        public string ComCiaBarrio { get; set; }
        public string ComCiaKilometro { get; set; }
        public string ComCiaCamino { get; set; }
        public string ComCiaBloque { get; set; }
        public string ComCiaCiudadela { get; set; }
        public string ComCiaReferenciaUbicacion { get; set; }
        public string ComCiaTelefono { get; set; }
        public string ComCiaTelefono2 { get; set; }
        public string ComCiaCelular { get; set; }
        public string ComCiaSitioWeb { get; set; }
        public decimal? ComCiaCapitalSuscrito { get; set; }
        public decimal? ComCiaCapitalPagado { get; set; }
        public decimal? ComCiaCapitalAutorizado { get; set; }
        public string ComCiaTipoCompania { get; set; }
        public string ComCiaEstadoLegal { get; set; }
        public DateTime? ComCiaVencimientoPlazo { get; set; }
        public DateTime? ComCiaFechaProrroga { get; set; }
        public long? ComCiaNumeroAcciones { get; set; }
        public decimal? ComCiaValorNominalAcciones { get; set; }
        public string ComCiaObjetoSocial { get; set; }
        public string ComActEcoDescripcion { get; set; }
        public bool ComIsActivo { get; set; }

        public DatosPrincipales Dp { get; set; }
        public ICollection<SuperciasAccionistas1> SuperciasAccionistas1 { get; set; }
        public ICollection<SuperciasAdministradores> SuperciasAdministradores { get; set; }
    }
}
