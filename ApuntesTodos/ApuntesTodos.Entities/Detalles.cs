using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesTodos.Entities
{
    public class Detalles
    {
        public int IdApunte { get; set; }
        public string NombreCompleto { get; set; }
        public string Origen { get; set; }
        public decimal Monto { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
    }
}
