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
    public partial class FrmProveedorE : Form
    {
        public string Modo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string Direccion { get; set; }
        public string NombreEmpresa { get; set; }
        ProveedorBLL bll= new ProveedorBLL();

        public FrmProveedorE()
        {
            InitializeComponent();
        }

        private void FrmProveedorE_Load(object sender, EventArgs e)
        {
            txtNe.Text = Nombre;
            txtEE.Text = NombreEmpresa;
            txtEt.Text = TelefonoEmpresa;
            txtED.Text = Direccion;
        }

        private void btnEP_Click(object sender, EventArgs e)
        {
            
                var r = MessageBox.Show("¿Estas seguro que desea eliminar al proveedor", "Confirmar eliminacion",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (r == DialogResult.No)
                    return;

                bll.Eliminar(Id);
                MessageBox.Show("El proveedor ha sido eliminada correctamente", "Operacion exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
        }
    }
}
