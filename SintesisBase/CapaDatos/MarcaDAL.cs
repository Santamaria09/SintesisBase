using SintesisBase.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SintesisBase.CapaDatos
{
    public class MarcaDAL
    {
        public DataTable Listar()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT m.Nombre, p.Nombre, p.NombreEmpresa as Proveedor FROM Marca m INNER JOIN Proveedor p on m.Id_Proveedor= p.Id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    con.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        Tabla.Load(dr);
                    }
                }
            }
            return Tabla;
        }
        public int Insertar(Marca m)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "INSERT INTO Marca (Nombre, Id_Proveedor) values (@nombre, @id_proveedor); SELECT SCOPE_IDENTITY();";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nombre", m.Nombre);
                    cmd.Parameters.AddWithValue("@id_proveedor", m.Id_Proveedor);
                    con.Open();
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }


        }
        public bool Actualizar(Marca m)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "UPDATE Marca SET Nombre=@nombre, Id_Proveedor =@id_proveedor WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", m.Id);
                    cmd.Parameters.AddWithValue("@nombre", m.Nombre);
                    cmd.Parameters.AddWithValue("@telefono", m.Id_Proveedor);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }
        public bool Eliminar(int Id)
        {
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = "DELETE FROM Marca WHERE Id=@id;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    con.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
            }

        }
        public DataTable Buscar(string filtro)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(Conexion.Cadena))
            {
                string sql = @"SELECT m.Nombre, p.NombreEmpresa as Proveedor FROM Marca m INNER JOIN Proveedor p on m.Id_Proveedor= p.Id WHERE m.Nombre LIKE @Filtro;";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Filtro", "%" + filtro + "%");
                    con.Open();
                    new SqlDataAdapter(cmd).Fill(dt);
                    return dt;
                }
            }
        }
    }
}
