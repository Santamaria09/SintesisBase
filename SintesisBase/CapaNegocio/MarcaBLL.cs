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
    public class MarcaBLL
    {
        MarcaDAL dal = new MarcaDAL();

        public DataTable Listar()
        {
            return dal.Listar();
        }

        public int Guardar( Marca m)
        {
            if (string.IsNullOrWhiteSpace(m.Modelo))
                throw new Exception("Debe ingresar el nombre de una marca");
            if (m.Id == 0)
            {
                MessageBox.Show("La Marca ha sido registrada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return dal.Insertar(m);
            }
            else
            {
                dal.Actualizar(m);
                MessageBox.Show("El registro ha sido actualizado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return m.Id;

            }
        }
        public bool Eliminar(int id)
        {
            return dal.Eliminar(id);

            MessageBox.Show("Registro eliminado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        public DataTable Buscar(string filtro)
        {
            return dal.Buscar(filtro);

        }
    }
}
