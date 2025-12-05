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
    public partial class FrmClientes : Form
    {
        ClientesBLL bll = new ClientesBLL();
        int ClientesID = 0;
        string modo = "Nuevo";

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
            HabilitarBotones();

        }

        void HabilitarBotones()
        {
            btnAgregarC.Enabled = true;
            btnEditarC.Enabled = false;
            btnEliminarC.Enabled = true;
            dvgClientes.ClearSelection();
            dvgClientes.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dvgClientes.SelectedRows.Count > 0;
                btnEditarC.Enabled = filaSeleccionada;
                btnEliminarC.Enabled = filaSeleccionada;
            };
        }

        void CargarDatos()
        {
            dvgClientes.DataSource = bll.Listar();
            dvgClientes.ClearSelection();
            ClientesID = 0;
        }

        private void btnAgregarC_Click(object sender, EventArgs e)
        {
            FrmAgregarC frm = new FrmAgregarC();
            frm.Modo = "Nuevo";
            frm.Id = 0;

            frm.ShowDialog();
            CargarDatos();


        }

        private void txtBuscarC_TextChanged(object sender, EventArgs e)
        {
            dvgClientes.DataSource = bll.Buscar(txtBuscarC.Text);
        }

        private void dvgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClientesID = Convert.ToInt32(dvgClientes.Rows[e.RowIndex].Cells["Id"].Value);
            }

        }

        private void btnEditarC_Click(object sender, EventArgs e)
        {
            if (ClientesID == 0)
            {
                MessageBox.Show("Sseleccionar a un Cliente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmAgregarC frm = new FrmAgregarC();
            frm.Modo = "Editar";
            frm.Id = ClientesID;

            frm.Nombre = dvgClientes.CurrentRow.Cells["Nombre"].Value.ToString();
            frm.Telefono = dvgClientes.CurrentRow.Cells["Telefono"].Value.ToString();
            frm.Direccion = dvgClientes.CurrentRow.Cells["Direccion"].Value.ToString();
            frm.Estado= Convert.ToBoolean(dvgClientes.CurrentRow.Cells["Estado"].Value);
           

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            if (ClientesID == 0)
            {
                MessageBox.Show("Seleccione un Cliente");
                return;
            }
            if (MessageBox.Show("¿Esta seguro de eliminar al usuario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bll.Eliminar(ClientesID);
                CargarDatos();
            }
        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
