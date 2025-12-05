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
    public partial class FrmActualizarUsuario : Form
    {
        private int Id;

        public FrmActualizarUsuario(int id)
        {         
        
            InitializeComponent();
            Id = id;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                bool ok = UsuarioBLL.Actualizar(
                    Id,
                    txtUsuario.Text.Trim(),
                    cmbRol.Text,
                    chkEstado.Checked
                );

                MessageBox.Show(ok ? "Actualizado" : "No se actualizó");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    

           

        private void FrmActualizarUsuario_Load(object sender, EventArgs e)
        {
            // 1. Traer los roles desde la base de datos
            List<string> roles = RolBLL.ListarRol(); // O ListarRoles si tu BLL tiene plural

            // 2. Asignarlos al ComboBox
            cmbRol.DataSource = roles;

            // 3. Cargar los datos del usuario
            var u = UsuarioBLL.Obtener(Id);
            txtUsuario.Text = u.NombreUsuario;

            // 4. Seleccionar el rol actual
            if (roles.Contains(u.Rol))
                cmbRol.SelectedItem = u.Rol;
            else
                cmbRol.SelectedIndex = -1;

            chkEstado.Checked = u.Estado;





        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
