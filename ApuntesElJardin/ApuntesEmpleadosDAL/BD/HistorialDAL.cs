using ApunteEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class HistorialDAL
    {

        public List<Historial> Historial_ObtenerTodos()
        {
            List<Historial> historial = new List<Historial>();

            string query = "select * from vw_VerHistorialPagosRestaurante order by FechaPago desc";

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Historial pago = new Historial()
                            {
                                IdPago = Convert.ToInt32(dr["IdPago"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Monto = Convert.ToDecimal(dr["Monto"]),
                                Detalle = dr["Detalle"].ToString(),
                                Origen = dr["Origen"].ToString(),
                                SePagoEn = dr["SePagoEn"].ToString(),
                                FechaPago = Convert.ToDateTime(dr["FechaPago"])
                            };
                            historial.Add(pago);
                        }
                    }
                }
            }
            return historial;
        }
    }
}
