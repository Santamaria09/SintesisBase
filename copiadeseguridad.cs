using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SintesisBase.CapaRepresentacion
{
    public partial class copiadeseguridad : Form
    {
        public copiadeseguridad()
        {
            InitializeComponent();
            timer1.Interval = 18000000;
            timer1.Enabled = true;
        }

        private void copiadeseguridad_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HacerBackupSQL();

        }
        private void HacerBackupSQL()
        {
            {

                string PUNTO_DISTRIBUCION_EMANUEL = "PUNTO_DISTRIBUCION_EMANUEL";
                string carpetaBackup = @"DESKTOP-V3GOA9H\SQLEXPRESS";

                if (!Directory.Exists(carpetaBackup))
                    Directory.CreateDirectory(carpetaBackup);

                string nombreArchivo = PUNTO_DISTRIBUCION_EMANUEL + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".bak";
                string rutaCompleta = Path.Combine(carpetaBackup, nombreArchivo);

                string cadenaConexion = "Server=DESKTOP-V3GOA9H\\SQLEXPRESS; Database=master; Integrated Security=True;";
                // O con usuario/contraseña:
                // string cadenaConexion = "Server=TU_SERVIDOR; Database=master; User Id=sa; Password=12345;";

                string query = $@" BACKUP DATABASE [{PUNTO_DISTRIBUCION_EMANUEL}] TO DISK = '{rutaCompleta}' WITH FORMAT, INIT;";





                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                }


            }
        }
    }
}
    

