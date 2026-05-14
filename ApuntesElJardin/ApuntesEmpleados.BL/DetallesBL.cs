using ApuntesEmpleados.DAL.BD;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.BL
{
    public class DetallesBL
    {

        private DetallesDAL detallesDAL = new DetallesDAL();

        public List<DetallesHeladeria> ObtenerDetallesHeladeria(int IdEmpleado)
        {
            return detallesDAL.ObtenerDetallesHeladeria(IdEmpleado);
        }

        public bool PagarApunte(int idApunte)
        {
            return detallesDAL.PagarApunte(idApunte);
        }
    }
}
