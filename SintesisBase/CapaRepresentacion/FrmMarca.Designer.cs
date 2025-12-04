namespace SintesisBase.CapaRepresentacion
{
    partial class FrmMarca
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
            this.dvgMarcas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarM = new System.Windows.Forms.Button();
            this.btnEditarM = new System.Windows.Forms.Button();
            this.btnEliminarM = new System.Windows.Forms.Button();
            this.btnVolverM = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscarM = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMarcas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgMarcas
            // 
            this.dvgMarcas.AllowUserToAddRows = false;
            this.dvgMarcas.BackgroundColor = System.Drawing.Color.White;
            this.dvgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMarcas.Location = new System.Drawing.Point(68, 135);
            this.dvgMarcas.Name = "dvgMarcas";
            this.dvgMarcas.ReadOnly = true;
            this.dvgMarcas.Size = new System.Drawing.Size(426, 291);
            this.dvgMarcas.TabIndex = 0;
            this.dvgMarcas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMarcas_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MARCAS RELACIONADAS";
            // 
            // btnAgregarM
            // 
            this.btnAgregarM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarM.Location = new System.Drawing.Point(21, 22);
            this.btnAgregarM.Name = "btnAgregarM";
            this.btnAgregarM.Size = new System.Drawing.Size(123, 45);
            this.btnAgregarM.TabIndex = 2;
            this.btnAgregarM.Text = "Agregar";
            this.btnAgregarM.UseVisualStyleBackColor = true;
            this.btnAgregarM.Click += new System.EventHandler(this.btnAgregarM_Click);
            // 
            // btnEditarM
            // 
            this.btnEditarM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarM.Location = new System.Drawing.Point(21, 90);
            this.btnEditarM.Name = "btnEditarM";
            this.btnEditarM.Size = new System.Drawing.Size(123, 46);
            this.btnEditarM.TabIndex = 3;
            this.btnEditarM.Text = "Actualizar";
            this.btnEditarM.UseVisualStyleBackColor = true;
            this.btnEditarM.Click += new System.EventHandler(this.btnEditarM_Click);
            // 
            // btnEliminarM
            // 
            this.btnEliminarM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarM.Location = new System.Drawing.Point(21, 155);
            this.btnEliminarM.Name = "btnEliminarM";
            this.btnEliminarM.Size = new System.Drawing.Size(123, 45);
            this.btnEliminarM.TabIndex = 4;
            this.btnEliminarM.Text = "Eliminar";
            this.btnEliminarM.UseVisualStyleBackColor = true;
            this.btnEliminarM.Click += new System.EventHandler(this.btnEliminarM_Click);
            // 
            // btnVolverM
            // 
            this.btnVolverM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverM.Location = new System.Drawing.Point(21, 222);
            this.btnVolverM.Name = "btnVolverM";
            this.btnVolverM.Size = new System.Drawing.Size(123, 45);
            this.btnVolverM.TabIndex = 5;
            this.btnVolverM.Text = "Regresar";
            this.btnVolverM.UseVisualStyleBackColor = true;
            this.btnVolverM.Click += new System.EventHandler(this.btnVolverM_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnVolverM);
            this.panel1.Controls.Add(this.btnAgregarM);
            this.panel1.Controls.Add(this.btnEditarM);
            this.panel1.Controls.Add(this.btnEliminarM);
            this.panel1.Location = new System.Drawing.Point(525, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 291);
            this.panel1.TabIndex = 6;
            // 
            // txtBuscarM
            // 
            this.txtBuscarM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarM.Location = new System.Drawing.Point(277, 74);
            this.txtBuscarM.Name = "txtBuscarM";
            this.txtBuscarM.Size = new System.Drawing.Size(297, 29);
            this.txtBuscarM.TabIndex = 7;
            this.txtBuscarM.TextChanged += new System.EventHandler(this.txtBuscarM_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(184, 77);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(71, 21);
            this.lblBuscar.TabIndex = 8;
            this.lblBuscar.Text = "Nombre:";
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(742, 472);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscarM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgMarcas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMarca";
            this.Text = "FrmMarca";
            this.Load += new System.EventHandler(this.FrmMarca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMarcas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgMarcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarM;
        private System.Windows.Forms.Button btnEditarM;
        private System.Windows.Forms.Button btnEliminarM;
        private System.Windows.Forms.Button btnVolverM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscarM;
        private System.Windows.Forms.Label lblBuscar;
    }
}