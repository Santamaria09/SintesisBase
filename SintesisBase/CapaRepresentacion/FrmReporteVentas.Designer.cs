namespace SintesisBase.CapaRepresentacion
{
    partial class FrmReporteVentas
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
            this.dptInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dptInicio
            // 
            this.dptInicio.Location = new System.Drawing.Point(142, 144);
            this.dptInicio.Name = "dptInicio";
            this.dptInicio.Size = new System.Drawing.Size(275, 29);
            this.dptInicio.TabIndex = 0;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(142, 214);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(275, 29);
            this.dtpFin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "REPORTES DE VENTAS";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(25, 150);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(94, 21);
            this.lblInicio.TabIndex = 3;
            this.lblInicio.Text = "Fecha inicio:";
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(25, 220);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(75, 21);
            this.lblFin.TabIndex = 4;
            this.lblFin.Text = "Fecha fin:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(89, 316);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(152, 47);
            this.btnGenerar.TabIndex = 5;
            this.btnGenerar.Text = "Generar reporte";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(265, 316);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(152, 47);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cancelar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(78, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 68);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(256, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 68);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(12, 205);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 51);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(12, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(118, 51);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(131, 36);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 63);
            this.panel5.TabIndex = 8;
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 423);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblFin);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dptInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmReporteVentas";
            this.Text = "FrmReporteVentas";
            this.Load += new System.EventHandler(this.FrmReporteVentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dptInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}