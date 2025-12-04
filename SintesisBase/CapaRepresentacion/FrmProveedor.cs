using SintesisBase.CapaEntidades;
using SintesisBase.CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintesisBase.CapaRepresentacion
{
    public partial class FrmProveedor : Form
    {
        public string Modo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string TelefonoEmpresa { get; set; }
        public string Direccion { get; set; }
        public string NombreEmpresa { get; set; }

        ProveedorBLL bll = new ProveedorBLL();
        public FrmProveedor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            if (Modo == "Nuevo")
            {
                label.Text = "AGREGAR PROVEEDOR";
            }
            else
            {
                label.Text = "MODIFICAR PROVEEDOR";
                txtNop.Text = Nombre;
                txtNpEmpresa.Text = NombreEmpresa;
                txtTelep.Text = TelefonoEmpresa;
                txtDirep.Text = Direccion;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnGp_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNop.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Proveedor p = new Proveedor
                {
                    Id = Id,
                    Nombre = txtNop.Text.Trim(),
                    NombreEmpresa = txtNpEmpresa.Text.Trim(),
                    TelefonoEmpresa = txtTelep.Text.Trim(),
                    Direccion = txtDirep.Text.Trim(),

                };
                bll.Guardar(p);
                MessageBox.Show(Modo == "Nuevo" ? "El proveedor ha sido registrado correctamente" : "Los cambios han sido guardados correctamente", "Operacion Exitosa",
                    MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al interactuar con la base de datos.\n\nDetalles tecnicos:\n" + ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado:\n" + ex.Message, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLp_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txtNop.Clear();
            txtNpEmpresa.Clear();
            txtTelep.Clear();
            txtDirep.Clear();
        }
    }
    
}
