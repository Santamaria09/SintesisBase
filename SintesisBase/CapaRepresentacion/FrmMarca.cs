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
    public partial class FrmMarca : Form
    {
        MarcaBLL bll = new MarcaBLL();
        int MarcaId = 0;
        string modo = "Nuevo";
        public FrmMarca()
        {
            InitializeComponent();
        }

        private void FrmMarca_Load(object sender, EventArgs e)
        {
            CargarDatos();
            HabilitarBotones();
        }
        void HabilitarBotones()
        {
            btnAgregarM.Enabled = true;
            btnEditarM.Enabled = false;
            btnEliminarM.Enabled = false;
            dvgMarcas.ClearSelection();
            dvgMarcas.SelectionChanged += (s, e) =>
            {
                bool filaSeleccionada = dvgMarcas.SelectedRows.Count > 0;
                btnEditarM.Enabled = filaSeleccionada;
                btnEliminarM.Enabled = filaSeleccionada;
            };
        }
        void CargarDatos()
        {
            dvgMarcas.DataSource = bll.Listar();
            dvgMarcas.ClearSelection();
            MarcaId= 0;
        }

        private void btnAgregarM_Click(object sender, EventArgs e)
        {
            FrmAgregarM frm = new FrmAgregarM();
            frm.Modo = "Nuevo";
            frm.Id = 0;

            frm.ShowDialog();
            CargarDatos();


        }

        private void txtBuscarM_TextChanged(object sender, EventArgs e)
        {
            dvgMarcas.DataSource = bll.Buscar(txtBuscarM.Text);
        }

        private void dvgMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                MarcaId = Convert.ToInt32(dvgMarcas.Rows[e.RowIndex].Cells["Id"].Value);
            }
        }

        private void btnEditarM_Click(object sender, EventArgs e)
        {

            if (MarcaId == 0)
            {
                MessageBox.Show("Sseleccione una Marca", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmAgregarM frm = new FrmAgregarM();
            frm.Modo = "Editar";
            frm.Id = MarcaId;

            frm.Modelo = dvgMarcas.CurrentRow.Cells["Modelo"].Value.ToString();
            frm.Id_Proveedor = Convert.ToInt32(dvgMarcas.CurrentRow.Cells["Id_Proveedor"].Value);

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnEliminarM_Click(object sender, EventArgs e)
        {
            if (MarcaId == 0)
            {
                MessageBox.Show("Seleccione una Marca a eliminar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmEliminarM frm = new FrmEliminarM();

            frm.Id = MarcaId;
            frm.Modelo = dvgMarcas.CurrentRow.Cells["Modelo"].Value.ToString();
            frm.Id_Proveedor = Convert.ToInt32(dvgMarcas.CurrentRow.Cells["Id_Proveedor"].Value);

            frm.ShowDialog();
            CargarDatos();
        }

        private void btnVolverM_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
