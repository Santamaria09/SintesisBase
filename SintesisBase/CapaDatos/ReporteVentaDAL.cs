using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaDatos
{
    internal class ReporteVentaDAL
    {

        // ==========================
        // REPORTE DE VENTAS
        // ==========================
        public DataTable ReporteVentas(DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_reporte_ventas_periodo", conn))
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

        public static DataTable ObtenerVentasPorPeriodo(DateTime inicio, DateTime fin)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                SqlCommand cmd = new SqlCommand("sp_reporte_ventas_periodo", conn);
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
