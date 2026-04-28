using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.Entities
{
    public class VerApuntesMiniMarket
    {
        public int IdApunte { get; set; }
        public string NombreCompleto { get; set; }
        public string Trabajo { get; set; }
        public string Origen { get; set; }
        public decimal Monto { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
    }
}
