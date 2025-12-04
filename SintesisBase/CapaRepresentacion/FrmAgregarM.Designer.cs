namespace SintesisBase.CapaRepresentacion
{
    partial class FrmAgregarM
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
            this.lblTituloM = new System.Windows.Forms.Label();
            this.txtNM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarCC = new System.Windows.Forms.Button();
            this.btnCancelarCC = new System.Windows.Forms.Button();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTituloM
            // 
            this.lblTituloM.AutoSize = true;
            this.lblTituloM.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloM.Location = new System.Drawing.Point(387, 39);
            this.lblTituloM.Name = "lblTituloM";
            this.lblTituloM.Size = new System.Drawing.Size(76, 25);
            this.lblTituloM.TabIndex = 18;
            this.lblTituloM.Text = "MARCA";
            // 
            // txtNM
            // 
            this.txtNM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNM.Location = new System.Drawing.Point(177, 119);
            this.txtNM.Name = "txtNM";
            this.txtNM.Size = new System.Drawing.Size(223, 29);
            this.txtNM.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Proveedor:";
            // 
            // btnGuardarCC
            // 
            this.btnGuardarCC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardarCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarCC.Location = new System.Drawing.Point(177, 236);
            this.btnGuardarCC.Name = "btnGuardarCC";
            this.btnGuardarCC.Size = new System.Drawing.Size(156, 36);
            this.btnGuardarCC.TabIndex = 23;
            this.btnGuardarCC.Text = "Guardar Marca";
            this.btnGuardarCC.UseVisualStyleBackColor = false;
            this.btnGuardarCC.Click += new System.EventHandler(this.btnGuardarCC_Click);
            // 
            // btnCancelarCC
            // 
            this.btnCancelarCC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelarCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCC.Location = new System.Drawing.Point(469, 236);
            this.btnCancelarCC.Name = "btnCancelarCC";
            this.btnCancelarCC.Size = new System.Drawing.Size(104, 36);
            this.btnCancelarCC.TabIndex = 24;
            this.btnCancelarCC.Text = "Cancelar";
            this.btnCancelarCC.UseVisualStyleBackColor = false;
            this.btnCancelarCC.Click += new System.EventHandler(this.btnCancelarCC_Click);
            // 
            // txtMP
            // 
            this.txtMP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMP.Location = new System.Drawing.Point(557, 119);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(136, 29);
            this.txtMP.TabIndex = 25;
            // 
            // FrmAgregarM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 335);
            this.Controls.Add(this.txtMP);
            this.Controls.Add(this.btnCancelarCC);
            this.Controls.Add(this.btnGuardarCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNM);
            this.Controls.Add(this.lblTituloM);
            this.Name = "FrmAgregarM";
            this.Text = "FrmAgregarM";
            this.Load += new System.EventHandler(this.FrmAgregarM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloM;
        private System.Windows.Forms.TextBox txtNM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarCC;
        private System.Windows.Forms.Button btnCancelarCC;
        private System.Windows.Forms.TextBox txtMP;
    }
}