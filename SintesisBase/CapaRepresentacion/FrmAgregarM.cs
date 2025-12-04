using SintesisBase.CapaDatos;
using SintesisBase.CapaEntidades;
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
    public partial class FrmAgregarM : Form
    {
        public string Modo { get; set; }
        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Id_Proveedor{ get; set; }

        MarcaBLL bll = new MarcaBLL();

        public FrmAgregarM()
        {
            InitializeComponent();
        }

        private void FrmAgregarM_Load(object sender, EventArgs e)
        {
            if (Modo == "Nuevo")
            {
                lblTituloM.Text = "AGREGAR MARCA";
            }
            else
            {
                lblTituloM.Text = "MODIFICAR MARCA";
                txtNM.Text = Modelo;
                txtMP.Text = Id_Proveedor.ToString();
                
            }
        }

        private void btnCancelarCC_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarCC_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtNM.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Marca m = new Marca
                {
                    Id = Id,
                    Modelo = txtNM.Text.Trim(),
                    Id_Proveedor = Convert.ToInt32(txtMP.Text.Trim())
                    
                };
                bll.Guardar(m);
                MessageBox.Show(Modo == "Nuevo" ? "La marca ha sido registrado correctamente" : "Los cambios han sido guardados correctamente", "Operacion Exitosa",
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
    }
    
}
