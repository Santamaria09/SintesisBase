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
    public partial class FrmAgregarC : Form
    {
        public string Modo { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Direccion {  get; set; }
        public bool Estado { get; set; }
        public bool EsSubsidio { get; set; }

        ClientesBLL bll = new ClientesBLL();
     
        public FrmAgregarC()
        {
            InitializeComponent();
        }

        private void FrmAgregarC_Load(object sender, EventArgs e)
        {
            if (Modo == "Nuevo")
            {
                lblTitulo.Text = "AGREGAR CLIENTE";

            }
            else
            {
                lblTitulo.Text = "MODIFICAR CATEGORIA";
                txtNombreCC.Text = Nombre;
                txtTelefonoCC.Text = Telefono;
                txtDireccionCC.Text = Direccion;
                chkEstadoCC.Checked = Estado;
                chkSubsidio.Checked = EsSubsidio;

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
                if (String.IsNullOrEmpty(txtNombreCC.Text))
                {
                    MessageBox.Show("Debe ingresar un nombre ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Clientes c = new Clientes
                {
                    Id = Id,
                    Nombre = txtNombreCC.Text.Trim(),
                    Telefono = txtTelefonoCC.Text.Trim(),
                    Direccion = txtDireccionCC.Text.Trim(),
                    Estado = chkEstadoCC.Checked,
                    EsSubsidio = chkSubsidio.Checked
                };
                bll.Guardar(c);
                MessageBox.Show(Modo == "Nuevo" ? "El cliente ha sido registrado correctamente" : "Los cambios han sido guardados correctamente", "Operacion Exitosa",
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
