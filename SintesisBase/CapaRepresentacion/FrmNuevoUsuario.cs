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
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                int id = UsuarioBLL.Insertar(
                    txtUsuario.Text.Trim(),
                    txtClave.Text.Trim(),
                    cmbRol.Text
                );

                MessageBox.Show("Usuario creado ID: " + id);
                this.Close(); // Cierra y vuelve al principal
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = RolBLL.ListarRol();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
