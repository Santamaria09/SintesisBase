namespace SintesisBase.CapaRepresentacion
{
    partial class FrmClientes
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
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarC = new System.Windows.Forms.TextBox();
            this.btnAgregarC = new System.Windows.Forms.Button();
            this.btnEliminarC = new System.Windows.Forms.Button();
            this.btnEditarC = new System.Windows.Forms.Button();
            this.btnVolverC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgClientes
            // 
            this.dvgClientes.AllowUserToAddRows = false;
            this.dvgClientes.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientes.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dvgClientes.Location = new System.Drawing.Point(94, 122);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.Size = new System.Drawing.Size(536, 239);
            this.dvgClientes.TabIndex = 0;
            this.dvgClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClientes_CellClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(120, 75);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(135, 21);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Nombre/Teléfono:";
            // 
            // txtBuscarC
            // 
            this.txtBuscarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarC.Location = new System.Drawing.Point(278, 72);
            this.txtBuscarC.Name = "txtBuscarC";
            this.txtBuscarC.Size = new System.Drawing.Size(297, 29);
            this.txtBuscarC.TabIndex = 2;
            this.txtBuscarC.TextChanged += new System.EventHandler(this.txtBuscarC_TextChanged);
            // 
            // btnAgregarC
            // 
            this.btnAgregarC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAgregarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarC.Location = new System.Drawing.Point(94, 387);
            this.btnAgregarC.Name = "btnAgregarC";
            this.btnAgregarC.Size = new System.Drawing.Size(118, 45);
            this.btnAgregarC.TabIndex = 3;
            this.btnAgregarC.Text = "Agregar";
            this.btnAgregarC.UseVisualStyleBackColor = false;
            this.btnAgregarC.Click += new System.EventHandler(this.btnAgregarC_Click);
            // 
            // btnEliminarC
            // 
            this.btnEliminarC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarC.Location = new System.Drawing.Point(235, 387);
            this.btnEliminarC.Name = "btnEliminarC";
            this.btnEliminarC.Size = new System.Drawing.Size(118, 45);
            this.btnEliminarC.TabIndex = 4;
            this.btnEliminarC.Text = "Eliminar";
            this.btnEliminarC.UseVisualStyleBackColor = false;
            this.btnEliminarC.Click += new System.EventHandler(this.btnEliminarC_Click);
            // 
            // btnEditarC
            // 
            this.btnEditarC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditarC.Location = new System.Drawing.Point(373, 387);
            this.btnEditarC.Name = "btnEditarC";
            this.btnEditarC.Size = new System.Drawing.Size(118, 45);
            this.btnEditarC.TabIndex = 5;
            this.btnEditarC.Text = "Editar";
            this.btnEditarC.UseVisualStyleBackColor = false;
            this.btnEditarC.Click += new System.EventHandler(this.btnEditarC_Click);
            // 
            // btnVolverC
            // 
            this.btnVolverC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnVolverC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolverC.Location = new System.Drawing.Point(512, 387);
            this.btnVolverC.Name = "btnVolverC";
            this.btnVolverC.Size = new System.Drawing.Size(118, 45);
            this.btnVolverC.TabIndex = 6;
            this.btnVolverC.Text = "Volver";
            this.btnVolverC.UseVisualStyleBackColor = false;
            this.btnVolverC.Click += new System.EventHandler(this.btnVolverC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SintesisBase.Properties.Resources.papel_de_registro;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(273, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Control de Clientes      ";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(716, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverC);
            this.Controls.Add(this.btnEditarC);
            this.Controls.Add(this.btnEliminarC);
            this.Controls.Add(this.btnAgregarC);
            this.Controls.Add(this.txtBuscarC);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dvgClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgClientes;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarC;
        private System.Windows.Forms.Button btnAgregarC;
        private System.Windows.Forms.Button btnEliminarC;
        private System.Windows.Forms.Button btnEditarC;
        private System.Windows.Forms.Button btnVolverC;
        private System.Windows.Forms.Label label1;
    }
}