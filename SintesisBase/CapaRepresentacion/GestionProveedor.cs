using SintesisBase.CapaEntidades;
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
        int ProveedorId = 0;
        string modo = "Nuevo";
        public GestionProveedor()
        {
            InitializeComponent();
        }

        private void GestionProveedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
            HabilitarBotones();

        }
        void HabilitarBotones()
        {
            btnAp.Enabled = true;
            btnEp.Enabled = false;
            btnEpp.Enabled = false;
            dvgProveedor.ClearSelection();
            dvgProveedor.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dvgProveedor.SelectedRows.Count > 0;
                btnEp.Enabled = filaSeleccionada;
                btnEpp.Enabled = filaSeleccionada;
            };
        }
        void CargarDatos()
        {
            dvgProveedor.DataSource = bll.Listar();
            dvgProveedor.ClearSelection();
            ProveedorId = 0;
        }

        private void btnAp_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.Modo = "Nuevo";
            frm.Id = 0;

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEp_Click(object sender, EventArgs e)
        {
            if (ProveedorId == 0)
            {
                MessageBox.Show("Sseleccione un Proveedor", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmProveedor frm = new FrmProveedor();
            frm.Modo = "Editar";
            frm.Id = ProveedorId;

            frm.Nombre = dvgProveedor.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.TelefonoEmpresa = dvgProveedor.CurrentRow.Cells["TelefonoEmpresa"].Value.ToString();
            frm.Direccion = dvgProveedor.CurrentRow.Cells["Direccion"].Value.ToString();
            frm.NombreEmpresa = dvgProveedor.CurrentRow.Cells["NombreEmpresa"].Value.ToString();


            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEpp_Click(object sender, EventArgs e)
        {
            if (ProveedorId == 0)
            {
                MessageBox.Show("Seleccione un proveedor a eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmProveedorE frm = new FrmProveedorE();

            frm.Id = ProveedorId;
            frm.Modelo = dvgMarcas.CurrentRow.Cells["Modelo"].Value.ToString();
            frm.Id_Proveedor = Convert.ToInt32(dvgMarcas.CurrentRow.Cells["Id_Proveedor"].Value);

            frm.ShowDialog();
            CargarDatos();
        }
    }
}
