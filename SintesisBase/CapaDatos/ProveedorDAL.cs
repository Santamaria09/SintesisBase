using SintesisBase.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaDatos
{
    public class ProveedorDAL
    {
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "SELECT Id, Nombre, TelefonoEmpresa, Direccion, NombreEmpresa FROM Proveedor";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                }
            }
            return dt;

        }
        public int Insertar(Proveedor p)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "INSERT INTO Proveedor (Nombre, TelefonoEmpresa, Direccion, NombreEmpresa) values (@nombre, @telefonoempresa, @direccion, @nombreempresa); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@telefonoEmpresa", p.TelefonoEmpresa);
                    cmd.Parameters.AddWithValue("@direccion", p.Direccion);
                    cmd.Parameters.AddWithValue("@NombreEmpresa", p.NombreEmpresa);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }


        }

        public bool Actualizar(Proveedor p)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "UPDATE Proveedor SET Nombre=@nombre, TelefonoEmpresa= @telefonoempresa, Direccion=@direccion, NombreEmpresa= @nombreempresa WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", p.Id);
                    cmd.Parameters.AddWithValue("@nombre", p.Nombre);
                    cmd.Parameters.AddWithValue("@telefonoempresa", p.TelefonoEmpresa);
                    cmd.Parameters.AddWithValue("@direccion", p.Direccion);
                    cmd.Parameters.AddWithValue("@nombreempresa", p.NombreEmpresa);

                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }

        public bool Eliminar(int id)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Proveedor WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }
        public static List<Proveedor> CatalogoProveedores(int id, string NombreEmpresa)
        {
            List<Proveedor> Lista = new List<Proveedor>();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT Id, Nombre, TelefonoEmpresa, Direccion, NombreEmpresa FROM Proveedor WHERE Id=@id AND NombreEmpresa = @nombreempresa;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@nombreempresa", NombreEmpresa );
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Lista.Add(new Proveedor
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Nombre = dr["Nombre"].ToString(),
                                TelefonoEmpresa = dr["TelefonoEmpresa"].ToString(),
                                Direccion = dr["Direccion"].ToString(),
                                NombreEmpresa = dr["Nombre"].ToString()


                            });
                        }
                    }
                }
                return Lista;
            }
        }
    }


        
}

