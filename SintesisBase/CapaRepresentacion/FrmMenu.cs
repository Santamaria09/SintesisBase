using SintesisBase.CapaRepresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SintesisBase.CapaEntidades;

namespace SintesisBase
{

    public partial class FrmMenu : Form
    {

        private FrmGestionUsuarios frmUsuarios; // <-- aquí
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {SesionActual.NombreUsuario} - Rol: {SesionActual.Rol}";

            /// Control básico por rol
//Con este codigo deshabilitamos un botón de prueba para el usuario cajero, por ejemplo que no pueda Registrar Cliente(ojo esto es solo prueba)
            switch (SesionActual.Rol)
            {
                case "Admin":
                    // todo habilitado
                    break;
                case "Cajero":
                    btnCliente.Enabled = false;
                    btnUsuario.Enabled = false;
                    break;
                default:
                    btnCliente.Enabled = false;
                    btnUsuario.Enabled = false;
                    break;
            

            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.Show();
           

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmAgregarPP frm = new FrmAgregarPP();
            frm.Show();
           
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // 1️⃣ Limpiar la sesión
            SesionActual.CerrarSesion(); // O SesionActual.Usuario = null;

            // 2️⃣ Abrir el formulario de inicio de sesión
            Iniciar_sesion login = new Iniciar_sesion();
            login.Show();

            // 3️⃣ Cerrar el formulario actual (menú principal)
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
           

        }

        private void tsCambiarClave_Click(object sender, EventArgs e)
        {
            FrmCambiarClave frm = new FrmCambiarClave();
            frm.ShowDialog();

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {

            if (frmUsuarios == null || frmUsuarios.IsDisposed)
            {
                frmUsuarios = new FrmGestionUsuarios();
            }

            frmUsuarios.Show();
            frmUsuarios.BringToFront();

        }

        private void msGenerarReportes_Click(object sender, EventArgs e)
        {
            

        }

        private void btnReportePDF_Click(object sender, EventArgs e)
        {
            FrmReporteVentas frm = new FrmReporteVentas();
            frm.ShowDialog();

        }

        private void btnReportePDFF_Click(object sender, EventArgs e)
        {
            FrmReporteCompras frm = new FrmReporteCompras();
            frm.ShowDialog();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            frmRegistrarVenta frm = new frmRegistrarVenta();
            frm.ShowDialog();
        }
    }
}
