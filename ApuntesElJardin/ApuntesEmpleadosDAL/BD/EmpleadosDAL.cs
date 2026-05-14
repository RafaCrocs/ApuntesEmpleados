using ApunteEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class EmpleadosDAL
    {

        public List<Empleado> Empleados_ObtenerTodos()
        {
            List<Empleado> empleados = new List<Empleado>();

            string query = "Select * from Empleados order by NombreCompleto";

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Empleado emp = new Empleado()
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Trabajo = dr["Trabajo"].ToString()
                            };
                            empleados.Add(emp);
                        }
                    }
                }
            }
            return empleados;
        }

        public bool Empleados_Insertar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_InsertarEmpleado", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreCompleto", empleado.NombreCompleto);
                        cmd.Parameters.AddWithValue("@Trabajo", empleado.Trabajo);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        mensaje = "Empleado insertado correctamente.";
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al insertar el empleado: {ex.Message}";
                return false;
            }
        }
    }
}
