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

        public List<DetallesMiniMarket> ObtenerDetallesMiniMarket(int IdEmpleado)
        {
            return detallesDAL.ObtenerDetallesMiniMarket(IdEmpleado);
        }

        public bool PagarApunte(int idApunte)
        {
            return detallesDAL.PagarApunte(idApunte);
        }
    }
}
