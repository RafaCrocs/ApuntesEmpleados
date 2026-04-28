using ApunteEmpleados.Entities;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class ApuntesDAL
    {

        public List<VerApuntesMiniMarket> Apuntes_ObtenerTodosMiniMarket()
        {
            string query = "select * from vw_ApuntesEmpleadosMiniMarket";
            List<VerApuntesMiniMarket> apuntesMiniMarkets = new List<VerApuntesMiniMarket>();
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                VerApuntesMiniMarket apunte = new VerApuntesMiniMarket
                                {
                                    IdApunte = Convert.ToInt32(reader["IdApunte"]),
                                    NombreCompleto = reader["NombreCompleto"].ToString(),
                                    Trabajo = reader["Trabajo"].ToString(),
                                    Origen = reader["Origen"].ToString(),
                                    Monto = Convert.ToDecimal(reader["Monto"]),
                                    Detalle = reader["Detalle"].ToString(),
                                    Fecha = Convert.ToDateTime(reader["Fecha"])
                                };
                                apuntesMiniMarkets.Add(apunte);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al obtener los apuntes: {ex.Message}");
                    }
                }
            }
            return apuntesMiniMarkets;
        }

        public bool AgregarApunte(Apunte apunte, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using(SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using(SqlCommand cmd = new SqlCommand("sp_InsertarApunte", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", apunte.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Origen", apunte.Origen);
                    cmd.Parameters.AddWithValue("@Monto", apunte.Monto);
                    cmd.Parameters.AddWithValue("@Detalle", apunte.Detalle);

                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        resultado = cmd.ExecuteNonQuery() > 0;
                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        mensaje = $"Error al agregar el apunte: {ex.Message}";
                    }
                }
            }

            return resultado;
        }

        public bool PagarApunte(int idApunte)
        {
            bool resultado = false;
            string query = "delete from Apuntes where IdApunte = @IdApunte";


            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdApunte", idApunte);
                    try
                    {
                        conn.Open();
                        resultado = cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al pagar el apunte: {ex.Message}");
                    }
                }
                return resultado;
            }
        }
    }
}
