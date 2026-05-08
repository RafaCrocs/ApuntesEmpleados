using ApuntesTodos.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ApuntesTodos.DAL
{
    public class DetallesDAL
    {

        public List<Detalles> Detalles_ObtenerPorEmpleado(int idEmpleado)
        {
            List<Detalles> lista = new();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("sp_DetalleApuntes", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Detalles
                            {
                                IdApunte = Convert.ToInt32(reader["IdApunte"]),
                                NombreCompleto = reader["NombreCompleto"].ToString()!,
                                Origen = reader["Origen"] == DBNull.Value ? "" : reader["Origen"].ToString()!,
                                Monto = reader["Monto"] == DBNull.Value ? 0m : Convert.ToDecimal(reader["Monto"]),
                                Detalle = reader["Detalle"] == DBNull.Value ? "" : reader["Detalle"].ToString()!,
                                Fecha = Convert.ToDateTime(reader["Fecha"])
                            });
                        }
                    }
                }
            }
            return lista;
        }
    }
}
