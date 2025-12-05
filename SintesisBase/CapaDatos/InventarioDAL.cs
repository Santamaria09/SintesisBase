using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaDatos
{
    public class InventarioDAL
    {
        public static int ObtenerStock(int Id_Producto)
        {
            int Stock = 0;

            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            //Conexion con la base de datos
            {
                string sql = "Select Stock FROM Inventario WHERE ID=@id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                //Devuelva los datos registrados 
                {
                    cmd.Parameters.AddWithValue("@id", Id_Producto);
                    con.Open();// Abrir la conexion
                    object result = cmd.ExecuteScalar();
                    if (result != null)

                        Stock = Convert.ToInt32(result);

                }
            }
            return Stock;
        }
        public static void ActualizarStock(int Id_Producto, decimal Cantidad)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "UPDATE Inventario SET Stock = Stock -@cantidad WHERE Id=@id";
                using (SqlCommand cmd = new SqlCommand  (sql, con))
                {
                    cmd.Parameters.AddWithValue("@cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@id", Id_Producto);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }               
            }
        }
    }
}
