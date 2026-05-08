using ApuntesTodos.DAL;
using ApuntesTodos.Entities;

namespace ApuntesTodos.BL
{
    public class DetallesBL
    {
        private readonly DetallesDAL detallesDAL = new();

        public List<Detalles> Detalles_ObtenerPorEmpleado(int idEmpleado)
        {
            return detallesDAL.Detalles_ObtenerPorEmpleado(idEmpleado);
        }
    }
}
