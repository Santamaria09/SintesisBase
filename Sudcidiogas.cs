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
    public partial class Sudcidiogas : Form
    {
        public Sudcidiogas()
        {
            InitializeComponent();
        }

        private void chkSubSidio_CheckedChanged(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(txtTotal.Text);
            decimal subsidio = 10; // ← AQUÍ el valor de subsidio fijo
            decimal totalFinal;

            if (chkSubSidio.Checked)
                totalFinal = total - subsidio;
            else
                totalFinal = total;

            txtTotalPagar.Text = totalFinal.ToString("0.00");



        }

        private void txtSubSidio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sudcidiogas_Load(object sender, EventArgs e)
        {

        }
    }
}
