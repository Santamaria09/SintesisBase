using SintesisBase.CapaDatos;
using SintesisBase.CapaEntidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SintesisBase.CapaRepresentacion
{
    public partial class frmRegistrarVenta : Form
    {
        public frmRegistrarVenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrarVenta_Load(object sender, EventArgs e)
        {
            cboC.DataSource = ClientesDAL.PanelDeContactos();
            cboC.DisplayMember = "Nombre";
            cboC.ValueMember = "Id";

            //TipoPago
            cboT.DataSource = MetodoPagoDAL.Listar();
            cboT.DisplayMember = "Nombre";
            cboT.ValueMember = "Id";

            //Fecha
            dtpT.Value = DateTime.Now;

            CargarProductos(string.Empty);

            //Columnas
            ConfigurarTablaDetalle();

        }

        private void CargarProductos(string filtro)
        {
            var Tabla = ProductoDAL.Listar();

            if (!string.IsNullOrWhiteSpace(filtro))
            {
                var dv = Tabla.DefaultView;
                dv.RowFilter = $"Nombre LIKE '%{filtro}%'";
                dvgBp.DataSource = dv;
            }
            else
            {
                dvgBp.DataSource = Tabla;
            }

            dvgBp.Columns["Id"].Visible = false;
        }
        private void ConfigurarTablaDetalle()
        {
            dvgDp.Columns.Clear();

            //Id producto
            DataGridViewTextBoxColumn colldProd = new DataGridViewTextBoxColumn();

            colldProd.Name = "Id_Producto";
            colldProd.HeaderText = "ID";
            colldProd.Visible = false;
            dvgDp.Columns.Add(colldProd);


            //Nombre producto
            dvgDp.Columns.Add("NombreProducto", "Producto");

            //Cantidad
            DataGridViewTextBoxColumn colCant = new DataGridViewTextBoxColumn();
            colCant.Name = "Cantidad";
            colCant.HeaderText = "Cant";
            dvgDp.Columns.Add(colCant);

            //Precio U
            DataGridViewTextBoxColumn colPrecio = new DataGridViewTextBoxColumn();
            colPrecio.Name = "PrecioUnitario";
            colPrecio.HeaderText = "Precio Unitario";
            dvgDp.Columns.Add(colPrecio);

            DataGridViewCheckBoxColumn colSubsidio = new DataGridViewCheckBoxColumn();
            colSubsidio.Name = "Subsidio";
            colSubsidio.HeaderText = "Subsidio";
            dvgDp.Columns.Add(colSubsidio);

            //Sub total
            DataGridViewTextBoxColumn colSub = new DataGridViewTextBoxColumn();
            colSub.Name = "SubTotal";
            colSub.HeaderText = "SubTotal";
            colSub.ReadOnly = true;
            dvgDp.Columns.Add(colSub);
            dvgDp.ReadOnly = false;

            //No editable
            dvgDp.Columns["SubTotal"].ReadOnly = true;
            dvgDp.Columns["PrecioUnitario"].ReadOnly = true;
            dvgDp.Columns["NombreProducto"].ReadOnly = true;
            dvgDp.Columns["Id_Producto"].ReadOnly = true;

            dvgDp.Columns["Cantidad"].ReadOnly = false;
        }

        private void btnpp_Click(object sender, EventArgs e)
        {
            string texto = txtpp.Text.Trim();
            CargarProductos(texto);
        }

        private void txtpp_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtpp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CargarProductos(txtpp.Text.Trim());
            }
        }

        private void dvgBp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgBp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DataGridViewRow row = dvgBp.SelectedRows[0];

            int Id_Producto = Convert.ToInt32(row.Cells["Id"].Value);
            string Nombre = row.Cells["Nombre"].Value.ToString();
            decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            int Cantidad = 1;
            decimal SubTotal = Precio * Cantidad;

            dvgDp.Rows.Add(
                IdProducto, Nombre, Cantidad, Precio, SubTotal);

            RecalcularTotal();
        }

        private void btnSubsidio_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnAp_Click(object sender, EventArgs e)
        {
            if (dvgBp.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            DataGridViewRow row = dvgBp.SelectedRows[0];

            int Id_Producto = Convert.ToInt32(row.Cells["Id"].Value);
            string Nombre = row.Cells["Nombre"].Value.ToString();
            decimal Precio = Convert.ToDecimal(row.Cells["Precio"].Value);

            int Cantidad = 1;

            decimal PrecioFinal = Precio - 12;
            decimal SubTotal = PrecioFinal * Cantidad;

            dvgDp.Rows.Add(
                Id_Producto,
                Nombre,
                Cantidad,
                PrecioFinal,
                SubTotal,
                true
            );

            RecalcularTotal();
        }
        private void RecalcularTotal()
        {
            decimal Total = 0;
            foreach (DataGridViewRow row in dvgDp.Rows)
            {
                Total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
            }
            label5.Text = "Total:$" + Total.ToString("0.00");
        }

        private void dvgDp_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dvgDp.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                DataGridViewRow row = dvgDp.Rows[e.RowIndex];

                int Cantidad;
                bool ok = int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out Cantidad);
                if (!ok || Cantidad <= 0)
                {
                    MessageBox.Show("Cantidad invalida");
                    row.Cells["Cantidad"].Value = 1;
                    Cantidad = 1;
                }

                decimal Precio = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value);
                decimal SubTotal = Cantidad * Precio;

                row.Cells["SubTotal"].Value = SubTotal;

                RecalcularTotal();
            }
        }
    }
    
    
}
