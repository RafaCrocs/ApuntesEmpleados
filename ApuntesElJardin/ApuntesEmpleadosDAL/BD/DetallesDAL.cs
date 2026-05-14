using ApunteEmpleados.Entities;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class DetallesDAL
    {

        public List<DetallesHeladeria> ObtenerDetallesHeladeria(int IdEmpleado)
        {
            List<DetallesHeladeria> detalles = new List<DetallesHeladeria>();
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_DetalleApuntesPorOrigen", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                    cmd.Parameters.AddWithValue("@Origen", "Heladeria");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DetallesHeladeria detalle = new DetallesHeladeria()
                            {
                                IdApunte = Convert.ToInt32(dr["IdApunte"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Trabajo = dr["Trabajo"].ToString(),
                                Origen = dr["Origen"].ToString(),
                                Monto = Convert.ToDecimal(dr["Monto"]),
                                Detalle = dr["Detalle"].ToString(),
                                Fecha = Convert.ToDateTime(dr["Fecha"])
                            };
                            detalles.Add(detalle);
                        }
                    }
                }
            }
            return detalles;
        }

        public bool PagarApunte(int idApunte)
        {
            bool resultado = false;
            try
            {

                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_PagarApunte", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdApunte", idApunte);
                        cmd.Parameters.AddWithValue("@Origen", "Heladeria");
                        cmd.Parameters.AddWithValue("@SePagoEn", "Heladeria");

                        cmd.Parameters.Add("@Resultado", System.Data.SqlDbType.Bit).Direction = System.Data.ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", System.Data.SqlDbType.VarChar, 200).Direction = System.Data.ParameterDirection.Output;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al pagar el apunte: " + ex.Message);
            }
            return resultado;
        }
    }
}
