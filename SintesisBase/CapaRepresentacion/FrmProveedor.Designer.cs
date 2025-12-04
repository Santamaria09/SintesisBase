namespace SintesisBase.CapaRepresentacion
{
    partial class FrmProveedor
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
            this.label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNpEmpresa = new System.Windows.Forms.TextBox();
            this.txtNop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDirep = new System.Windows.Forms.TextBox();
            this.txtTelep = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnGp = new System.Windows.Forms.Button();
            this.btnLp = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(47, 16);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(100, 21);
            this.label.TabIndex = 0;
            this.label.Text = "PROVEEDOR";
            this.label.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtNpEmpresa);
            this.groupBox1.Controls.Add(this.txtNop);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(43, 140);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(431, 183);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales:";
            // 
            // txtNpEmpresa
            // 
            this.txtNpEmpresa.Location = new System.Drawing.Point(183, 106);
            this.txtNpEmpresa.Name = "txtNpEmpresa";
            this.txtNpEmpresa.Size = new System.Drawing.Size(197, 29);
            this.txtNpEmpresa.TabIndex = 6;
            // 
            // txtNop
            // 
            this.txtNop.Location = new System.Drawing.Point(183, 36);
            this.txtNop.Name = "txtNop";
            this.txtNop.Size = new System.Drawing.Size(197, 29);
            this.txtNop.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de la empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.txtDirep);
            this.groupBox2.Controls.Add(this.txtTelep);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(504, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox2.Size = new System.Drawing.Size(397, 183);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de contacto:";
            // 
            // txtDirep
            // 
            this.txtDirep.Location = new System.Drawing.Point(183, 101);
            this.txtDirep.Name = "txtDirep";
            this.txtDirep.Size = new System.Drawing.Size(197, 29);
            this.txtDirep.TabIndex = 7;
            // 
            // txtTelep
            // 
            this.txtTelep.Location = new System.Drawing.Point(183, 42);
            this.txtTelep.Name = "txtTelep";
            this.txtTelep.Size = new System.Drawing.Size(197, 29);
            this.txtTelep.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Telefono de la empresa:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // bnGp
            // 
            this.bnGp.Location = new System.Drawing.Point(95, 360);
            this.bnGp.Name = "bnGp";
            this.bnGp.Size = new System.Drawing.Size(146, 49);
            this.bnGp.TabIndex = 5;
            this.bnGp.Text = "Guardar";
            this.bnGp.UseVisualStyleBackColor = true;
            this.bnGp.Click += new System.EventHandler(this.bnGp_Click);
            // 
            // btnLp
            // 
            this.btnLp.Location = new System.Drawing.Point(294, 360);
            this.btnLp.Name = "btnLp";
            this.btnLp.Size = new System.Drawing.Size(146, 49);
            this.btnLp.TabIndex = 7;
            this.btnLp.Text = "Limpiar camps";
            this.btnLp.UseVisualStyleBackColor = true;
            this.btnLp.Click += new System.EventHandler(this.btnLp_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(775, 462);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 48);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(374, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 57);
            this.panel1.TabIndex = 9;
            // 
            // FrmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(953, 533);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnLp);
            this.Controls.Add(this.bnGp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmProveedor";
            this.Text = "FrmProveedor";
            this.Load += new System.EventHandler(this.FrmProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNpEmpresa;
        private System.Windows.Forms.TextBox txtNop;
        private System.Windows.Forms.TextBox txtDirep;
        private System.Windows.Forms.TextBox txtTelep;
        private System.Windows.Forms.Button bnGp;
        private System.Windows.Forms.Button btnLp;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
    }
}