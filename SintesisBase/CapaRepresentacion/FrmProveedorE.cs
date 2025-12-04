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
    public partial class FrmProveedorE : Form
    {
        public string Modo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string Direccion { get; set; }
        public string NombreEmpresa { get; set; }
        public FrmProveedorE()
        {
            InitializeComponent();
        }

        private void FrmProveedorE_Load(object sender, EventArgs e)
        {

        }
    }
}
