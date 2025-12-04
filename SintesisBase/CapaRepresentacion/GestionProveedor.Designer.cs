namespace SintesisBase.CapaRepresentacion
{
    partial class GestionProveedor
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
            this.dvgProveedor = new System.Windows.Forms.DataGridView();
            this.txtBp = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVp = new System.Windows.Forms.Button();
            this.btnAp = new System.Windows.Forms.Button();
            this.btnEpp = new System.Windows.Forms.Button();
            this.btnEp = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProveedor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgProveedor
            // 
            this.dvgProveedor.AllowUserToAddRows = false;
            this.dvgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProveedor.Location = new System.Drawing.Point(108, 116);
            this.dvgProveedor.Name = "dvgProveedor";
            this.dvgProveedor.ReadOnly = true;
            this.dvgProveedor.Size = new System.Drawing.Size(580, 190);
            this.dvgProveedor.TabIndex = 0;
            this.dvgProveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgProveedor_CellClick);
            // 
            // txtBp
            // 
            this.txtBp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBp.Location = new System.Drawing.Point(328, 70);
            this.txtBp.Name = "txtBp";
            this.txtBp.Size = new System.Drawing.Size(297, 29);
            this.txtBp.TabIndex = 8;
            this.txtBp.TextChanged += new System.EventHandler(this.txtBp_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(186, 73);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(71, 21);
            this.lblBuscar.TabIndex = 9;
            this.lblBuscar.Text = "Nombre:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnVp);
            this.panel1.Controls.Add(this.btnAp);
            this.panel1.Controls.Add(this.btnEpp);
            this.panel1.Controls.Add(this.btnEp);
            this.panel1.Location = new System.Drawing.Point(108, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 97);
            this.panel1.TabIndex = 10;
            // 
            // btnVp
            // 
            this.btnVp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVp.Location = new System.Drawing.Point(437, 22);
            this.btnVp.Name = "btnVp";
            this.btnVp.Size = new System.Drawing.Size(123, 45);
            this.btnVp.TabIndex = 5;
            this.btnVp.Text = "Regresar";
            this.btnVp.UseVisualStyleBackColor = true;
            this.btnVp.Click += new System.EventHandler(this.btnVp_Click);
            // 
            // btnAp
            // 
            this.btnAp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAp.Location = new System.Drawing.Point(21, 22);
            this.btnAp.Name = "btnAp";
            this.btnAp.Size = new System.Drawing.Size(123, 45);
            this.btnAp.TabIndex = 2;
            this.btnAp.Text = "Agregar";
            this.btnAp.UseVisualStyleBackColor = true;
            this.btnAp.Click += new System.EventHandler(this.btnAp_Click);
            // 
            // btnEpp
            // 
            this.btnEpp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEpp.Location = new System.Drawing.Point(297, 22);
            this.btnEpp.Name = "btnEpp";
            this.btnEpp.Size = new System.Drawing.Size(123, 45);
            this.btnEpp.TabIndex = 4;
            this.btnEpp.Text = "Eliminar";
            this.btnEpp.UseVisualStyleBackColor = true;
            this.btnEpp.Click += new System.EventHandler(this.btnEpp_Click);
            // 
            // btnEp
            // 
            this.btnEp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEp.Location = new System.Drawing.Point(159, 21);
            this.btnEp.Name = "btnEp";
            this.btnEp.Size = new System.Drawing.Size(123, 46);
            this.btnEp.TabIndex = 3;
            this.btnEp.Text = "Actualizar";
            this.btnEp.UseVisualStyleBackColor = true;
            this.btnEp.Click += new System.EventHandler(this.btnEp_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(276, 26);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(247, 25);
            this.l.TabIndex = 11;
            this.l.Text = "GESTION DE PROVEEDORES";
            // 
            // GestionProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBp);
            this.Controls.Add(this.dvgProveedor);
            this.Name = "GestionProveedor";
            this.Text = "GestionProveedor";
            this.Load += new System.EventHandler(this.GestionProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProveedor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgProveedor;
        private System.Windows.Forms.TextBox txtBp;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVp;
        private System.Windows.Forms.Button btnAp;
        private System.Windows.Forms.Button btnEpp;
        private System.Windows.Forms.Button btnEp;
        private System.Windows.Forms.Label l;
    }
}