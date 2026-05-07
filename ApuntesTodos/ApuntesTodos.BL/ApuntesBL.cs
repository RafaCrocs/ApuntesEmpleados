using ApuntesTodos.DAL;
using ApuntesTodos.Entities;

namespace ApuntesTodos.BL
{
    public class ApuntesBL
    {

        private ApuntesDAL apuntesDAL = new ApuntesDAL();

        public List<Apuntes> Apuntes_ObtenerTodos()
        {
            return apuntesDAL.Apuntes_ObtenerTodos();
        }

        public bool Eliminar_Apuntes_Empleado(int IdEmpleado)
        {
            return apuntesDAL.Eliminar_Apuntes_Empleado(IdEmpleado);
        }

        public bool Pagar_Todos()
        {
            return apuntesDAL.Pagar_Todos();
        }

    }
}
