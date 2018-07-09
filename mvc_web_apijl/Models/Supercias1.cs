using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Supercias1
    {
        public Supercias1()
        {
            SuperciasAccionistas = new HashSet<SuperciasAccionistas>();
            SuperciasAdministradores1 = new HashSet<SuperciasAdministradores1>();
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
        public string ComCiaVencimientoPlazo { get; set; }
        public DateTime? ComCiaFechaProrroga { get; set; }
        public int? ComCiaNumeroAcciones { get; set; }
        public decimal? ComCiaValorNominalAcciones { get; set; }
        public string ComCiaObjetoSocial { get; set; }
        public string ComActEcoCiiu4 { get; set; }
        public string ComActEcoDescripcion { get; set; }
        public bool ComIsActivo { get; set; }

        public DatosPrincipales1 Dp { get; set; }
        public ICollection<SuperciasAccionistas> SuperciasAccionistas { get; set; }
        public ICollection<SuperciasAdministradores1> SuperciasAdministradores1 { get; set; }
    }
}
