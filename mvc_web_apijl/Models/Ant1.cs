using System;
using System.Collections.Generic;

namespace mvc_web_apijl.Models
{
    public partial class Ant1
    {
        public int AntVehiculoId { get; set; }
        public int DpId { get; set; }
        public string AntVehiculoChasis { get; set; }
        public string AntVehiculoMotor { get; set; }
        public string AntVehiculoMarca { get; set; }
        public string AntVehiculoModelo { get; set; }
        public string AntVehiculoEstado { get; set; }
        public bool AntVehiculoIsActivo { get; set; }
        public string AntVehiculoPlaca { get; set; }

        public DatosPrincipales1 Dp { get; set; }
    }
}
