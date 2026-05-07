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
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
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

        public bool Eliminar_Apuntes_Empleado(int IdEmpleado)
        {
            bool resultado = false;
            string query = @"Delete from Apuntes where IdEmpleado = @IdEmpleado";
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);

                        resultado = cmd.ExecuteNonQuery() > 0;

                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al pagar el apunte: {ex.Message}");
            }

            return resultado;
        }

        public bool Pagar_Todos()
        {
            bool resultado = false;
            string query = @"Delete from Apuntes";
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                        resultado = cmd.ExecuteNonQuery() > 0;

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al pagar los apuntes: {ex.Message}");
            }

            return resultado;
        }

    }
}
