using SintesisBase.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintesisBase.CapaRepresentacion
{
    public partial class FrmEliminarM : Form
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Id_Proveedor { get; set; }

        MarcaBLL bll = new MarcaBLL();

        public FrmEliminarM()
        {
            InitializeComponent();
        }

        private void FrmEliminarM_Load(object sender, EventArgs e)
        {
            txtME.Text = Modelo;
            txtMID.Text = Id_Proveedor.ToString();

        }

        private void btnEM_Click(object sender, EventArgs e)
        {

            try
            {
                var r = MessageBox.Show($"¿Estas seguro que desea eliminar la marca" , "Confirmar eliminacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.No)
                    return;

                bll.Eliminar(Id);
                MessageBox.Show("La marca ha sido eliminada correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    MessageBox.Show("No se puede eliminar esta esta marca porque esta asociada a otros registros\n" + "Actualice o elimine esos registros primero", "Eliminacion no permitida",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                MessageBox.Show("Ocurrio un error al intertar eliminar la marca\n\nDetalles tecnicos:\n" + ex.Message, "Error SQL",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado:\n" + ex.Message, "Error general",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
    
}
