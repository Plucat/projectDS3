using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Pelicula
{
    internal static class DbHelper
    {
        private static readonly string StringConexion = "Server=localhost\\DS3;Database=Cine;Integrated Security=True;TrustServerCertificate=True;Trusted_Connection=True;";

        public static DataTable Consultar(string query, SqlParameter[] parametros = null)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(StringConexion))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        if (parametros != null)
                            cmd.Parameters.AddRange(parametros);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt); // adapter abre la conexion si esta cerrada
                        }
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error SQL:\n" + ex.Message, "Error al consultar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }



        public static bool Ejecutar(string query, SqlParameter[] parametros = null) 
        {
            try
            {
                using (SqlConnection con = new SqlConnection(StringConexion)) 
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();

                        if (parametros != null)
                            cmd.Parameters.AddRange(parametros);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error SQL:\n" + ex.Message, "Error al ejecutar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}