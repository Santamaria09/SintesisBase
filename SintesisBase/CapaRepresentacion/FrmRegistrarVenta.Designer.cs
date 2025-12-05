namespace SintesisBase.CapaRepresentacion
{
    partial class frmRegistrarVenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dvgBp = new System.Windows.Forms.DataGridView();
            this.btnpp = new System.Windows.Forms.Button();
            this.txtpp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dvgDp = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAp = new System.Windows.Forms.Button();
            this.chkA = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBp)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDp)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.dtpT);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales:";
            // 
            // dtpT
            // 
            this.dtpT.Location = new System.Drawing.Point(778, 29);
            this.dtpT.Name = "dtpT";
            this.dtpT.Size = new System.Drawing.Size(200, 29);
            this.dtpT.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(719, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha:";
            // 
            // cboT
            // 
            this.cboT.FormattingEnabled = true;
            this.cboT.Location = new System.Drawing.Point(512, 28);
            this.cboT.Name = "cboT";
            this.cboT.Size = new System.Drawing.Size(180, 29);
            this.cboT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(403, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de pago:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Registrar ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboC
            // 
            this.cboC.FormattingEnabled = true;
            this.cboC.Location = new System.Drawing.Point(100, 28);
            this.cboC.Name = "cboC";
            this.cboC.Size = new System.Drawing.Size(180, 29);
            this.cboC.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.chkA);
            this.groupBox2.Controls.Add(this.btnAp);
            this.groupBox2.Controls.Add(this.dvgBp);
            this.groupBox2.Controls.Add(this.btnpp);
            this.groupBox2.Controls.Add(this.txtpp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(22, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 317);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos:";
            // 
            // dvgBp
            // 
            this.dvgBp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgBp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBp.Location = new System.Drawing.Point(23, 82);
            this.dvgBp.Name = "dvgBp";
            this.dvgBp.ReadOnly = true;
            this.dvgBp.Size = new System.Drawing.Size(440, 150);
            this.dvgBp.TabIndex = 8;
            this.dvgBp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgBp_CellDoubleClick);
            // 
            // btnpp
            // 
            this.btnpp.Location = new System.Drawing.Point(361, 28);
            this.btnpp.Name = "btnpp";
            this.btnpp.Size = new System.Drawing.Size(89, 36);
            this.btnpp.TabIndex = 6;
            this.btnpp.Text = "Buscar";
            this.btnpp.UseVisualStyleBackColor = true;
            this.btnpp.Click += new System.EventHandler(this.btnpp_Click);
            // 
            // txtpp
            // 
            this.txtpp.Location = new System.Drawing.Point(175, 32);
            this.txtpp.Name = "txtpp";
            this.txtpp.Size = new System.Drawing.Size(142, 29);
            this.txtpp.TabIndex = 7;
            this.txtpp.TextChanged += new System.EventHandler(this.txtpp_TextChanged);
            this.txtpp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpp_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buscar producto:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.dvgDp);
            this.groupBox3.Location = new System.Drawing.Point(534, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(481, 317);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detales de venta:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(235, 255);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(169, 41);
            this.button5.TabIndex = 10;
            this.button5.Text = "Limpiar todo";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(38, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(169, 41);
            this.button4.TabIndex = 9;
            this.button4.Text = "Eliminar una fila";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dvgDp
            // 
            this.dvgDp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dvgDp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDp.Location = new System.Drawing.Point(38, 50);
            this.dvgDp.Name = "dvgDp";
            this.dvgDp.ReadOnly = true;
            this.dvgDp.Size = new System.Drawing.Size(401, 150);
            this.dvgDp.TabIndex = 8;
            this.dvgDp.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDp_CellEndEdit);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto total \"Total: $0.00\"";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(287, 14);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 32);
            this.button6.TabIndex = 10;
            this.button6.Text = "Registrar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(880, 483);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 34);
            this.button7.TabIndex = 11;
            this.button7.Text = "Cerrar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(45, 470);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 58);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Total:";
            // 
            // btnAp
            // 
            this.btnAp.Location = new System.Drawing.Point(100, 259);
            this.btnAp.Name = "btnAp";
            this.btnAp.Size = new System.Drawing.Size(120, 32);
            this.btnAp.TabIndex = 11;
            this.btnAp.Text = "Registrar";
            this.btnAp.UseVisualStyleBackColor = true;
            this.btnAp.Click += new System.EventHandler(this.btnAp_Click);
            // 
            // chkA
            // 
            this.chkA.AutoSize = true;
            this.chkA.Location = new System.Drawing.Point(310, 264);
            this.chkA.Name = "chkA";
            this.chkA.Size = new System.Drawing.Size(77, 25);
            this.chkA.TabIndex = 12;
            this.chkA.Text = "Aplicar";
            this.chkA.UseVisualStyleBackColor = true;
            // 
            // frmRegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1037, 540);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmRegistrarVenta";
            this.Text = "RegistrarVenta";
            this.Load += new System.EventHandler(this.frmRegistrarVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBp)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDp)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboC;
        private System.Windows.Forms.DateTimePicker dtpT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dvgBp;
        private System.Windows.Forms.Button btnpp;
        private System.Windows.Forms.TextBox txtpp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dvgDp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAp;
        private System.Windows.Forms.CheckBox chkA;
    }
}