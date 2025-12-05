namespace SintesisBase.CapaRepresentacion
{
    partial class Sudcidiogas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubSidio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSubSidio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.Location = new System.Drawing.Point(449, 242);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPagar.TabIndex = 0;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(297, 242);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 1;
            // 
            // txtSubSidio
            // 
            this.txtSubSidio.Location = new System.Drawing.Point(132, 242);
            this.txtSubSidio.Name = "txtSubSidio";
            this.txtSubSidio.Size = new System.Drawing.Size(100, 20);
            this.txtSubSidio.TabIndex = 2;
            this.txtSubSidio.TextChanged += new System.EventHandler(this.txtSubSidio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total a Pagar";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(156, 210);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(49, 13);
            this.label.TabIndex = 4;
            this.label.Text = "SubSidio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // chkSubSidio
            // 
            this.chkSubSidio.AutoSize = true;
            this.chkSubSidio.Location = new System.Drawing.Point(297, 328);
            this.chkSubSidio.Name = "chkSubSidio";
            this.chkSubSidio.Size = new System.Drawing.Size(68, 17);
            this.chkSubSidio.TabIndex = 6;
            this.chkSubSidio.Text = "SubSidio";
            this.chkSubSidio.UseVisualStyleBackColor = true;
            this.chkSubSidio.CheckedChanged += new System.EventHandler(this.chkSubSidio_CheckedChanged);
            // 
            // Sudcidiogas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.chkSubSidio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubSidio);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTotalPagar);
            this.Name = "Sudcidiogas";
            this.Text = "Sudcidiogas";
            this.Load += new System.EventHandler(this.Sudcidiogas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubSidio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSubSidio;
    }
}