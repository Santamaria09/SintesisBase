using SintesisBase.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintesisBase.CapaRepresentacion
{
    public partial class GestionProveedor : Form
    {
        ProveedorBLL bll = new ProveedorBLL();
        int MarcaId = 0;
        string modo = "Nuevo";
        public GestionProveedor()
        {
            InitializeComponent();
        }

        private void GestionProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
