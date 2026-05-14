using ApunteEmpleados.Entities;
using ApuntesEmpleados.DAL.BD;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.BL
{
    public class ApuntesBL
    {

        private ApuntesDAL apuntesDAL = new ApuntesDAL();

        public List<VerApuntesMiniMarket> ApuntesMiniMarket()
        {
            return apuntesDAL.Apuntes_ObtenerTodosMiniMarket();
        }

        public bool AgregarApunte(Apunte apunte, out string mensaje)
        {
            return apuntesDAL.AgregarApunte(apunte, out mensaje);
        }

        public bool PagarApunte(int idApunte)
        {
            return apuntesDAL.PagarApunte(idApunte);
        }

        public bool PagarTodo(int IdEmpleado)
        {
            return apuntesDAL.PagarTodo(IdEmpleado);
        }
    }
}
