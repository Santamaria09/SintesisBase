using SintesisBase.CapaDatos;
using SintesisBase.CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintesisBase.CapaNegocio
{
    public class ProveedorBLL
    {
        ProveedorDAL dal = new ProveedorDAL();
        public DataTable Listar()
        {
            return dal.Listar();

        }
        public int Guardar(Proveedor p)
        {
            if (string.IsNullOrWhiteSpace(p.Nombre))
                throw new Exception("El nombre del proveedor es obligatorio");

            if (p.TelefonoEmpresa.Length <= 8)
                throw new Exception("El telefono no debe superar 8 digitos");

            if (p.Id == 0)
            {


                MessageBox.Show("Proveedor registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dal.Insertar(p);
            }
            else
            {
                dal.Actualizar(p);
                MessageBox.Show("El registro ha sido actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return p.Id;

            }

        }
        public bool Eliminar(int id)
        {
            return dal.Eliminar(id);

            MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }
    }
}
