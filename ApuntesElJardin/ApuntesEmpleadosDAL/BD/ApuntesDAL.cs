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
            List<VerApuntesMiniMarket> apuntesMiniMarkets = new List<VerApuntesMiniMarket>();
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ObtenerApuntesPorOrigen", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Origen", "MiniMarket");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                VerApuntesMiniMarket apunte = new VerApuntesMiniMarket
                                {
                                    IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                    NombreCompleto = reader["NombreCompleto"].ToString(),
                                    Trabajo = reader["Trabajo"].ToString(),
                                    Monto = Convert.ToDecimal(reader["Monto"])
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

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarApunte", conn))
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


            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_PagarApunte", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdApunte", idApunte);
                    cmd.Parameters.AddWithValue("@Origen", "MiniMarket");
                    cmd.Parameters.AddWithValue("@SePagoEn", "MiniMarket");

                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

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

        public bool PagarTodo(int idEmpleado)
        {
            bool resultado = false;
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_PagarTodo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@SePagoEn", "MiniMarket");
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        resultado = cmd.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al pagar todos los apuntes: {ex.Message}");
                    }
                }
            }
            return resultado;
        }
    }
}
