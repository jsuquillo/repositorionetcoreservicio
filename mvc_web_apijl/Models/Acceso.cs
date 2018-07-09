using System;
using System.Collections.Generic;
using System.Net;

namespace mvc_web_apijl.Models
{
    public partial class Acceso
    {
        public int IdAcceso { get; set; }
        public int IdUsuario { get; set; }
        public string Cuenta { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public IPAddress Ip { get; set; }
        public short Estado { get; set; }
    }
}
