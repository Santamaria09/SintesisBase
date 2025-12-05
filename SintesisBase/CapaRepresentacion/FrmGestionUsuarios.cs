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
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FrmGestionUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            dgvUsuarios.DataSource = UsuarioBLL.Listar().Select(u => new {
                u.IdUsuario,
                u.NombreUsuario,
                u.Rol,
                Estado = u.Estado ? "Activo" : "Inactivo"
            }).ToList();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona uno para eliminar.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);

            var r = MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                bool ok = UsuarioBLL.Eliminar(id);
                MessageBox.Show(ok ? "Eliminado" : "No eliminado");
                CargarUsuarios();
            }

        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void Limpiar()
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frm = new FrmNuevoUsuario();
            frm.ShowDialog();
            CargarUsuarios();  // Refresca al cerrar
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un usuario para actualizar.");
                return;
            }

            int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);

            FrmActualizarUsuario frm = new FrmActualizarUsuario(id);
            frm.ShowDialog();

            CargarUsuarios(); // refrescar después de cerrar
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
