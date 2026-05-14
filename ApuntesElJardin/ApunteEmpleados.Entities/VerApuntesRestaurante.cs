using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.Entities
{
    public class VerApuntesRestaurante
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string Trabajo { get; set; }
        public decimal Monto { get; set; }
    }
}
