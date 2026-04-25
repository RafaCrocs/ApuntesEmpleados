using ApuntesTodos.Entities;
using System.Data.SqlClient;

namespace ApuntesTodos.DAL
{
    public class ApuntesDAL
    {

        public List<Apuntes> Apuntes_ObtenerTodos()
        {
            List<Apuntes> apuntes = new();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("sp_ObtenerApuntesEmpleados", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Apuntes apunte = new Apuntes
                            {
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                Trabajo = reader["Trabajo"].ToString(),
                                MiniMarket = Convert.ToDecimal(reader["MiniMarket"]),
                                Souvenir = Convert.ToDecimal(reader["Souvenir"]),
                                Restaurante = Convert.ToDecimal(reader["Restaurante"]),
                                Heladeria = Convert.ToDecimal(reader["Heladeria"]),
                                Total = Convert.ToDecimal(reader["Total"])
                            };
                            apuntes.Add(apunte);
                        }
                    }
                }
            }
            return apuntes;
        }
    }
}
