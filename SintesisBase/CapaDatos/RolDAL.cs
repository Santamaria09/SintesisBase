using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaDatos
{
    public class RolDAL
    {
        public static List<string> ListarRol()
        {
            List<string> Rol = new List<string>();
            using (var con = new SqlConnection(Conexion.Cadena))
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT Nombre FROM Rol", con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Rol.Add(dr["Nombre"].ToString());
                    }
                }
            }
            return Rol;
        }
    }
}

