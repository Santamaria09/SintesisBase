using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaDatos
{
    internal class ReporteCompraDAL
    {
        // ==========================
        // REPORTE DE COMPRAS
        // ==========================
        public DataTable ReporteCompras(DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_reporte_compras_proveedores", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio", inicio.Date);
                    cmd.Parameters.AddWithValue("@FechaFin", fin.Date);

                    conn.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        tabla.Load(dr);
                    }
                }
            }

            return tabla;
        }

        public static DataTable ObtenerComprasPorPeriodo(DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_reporte_compras_proveedores", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechaInicio", inicio);
                cmd.Parameters.AddWithValue("@FechaFin", fin);

                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabla);
            }

            return tabla;
        }
    }
}
    

