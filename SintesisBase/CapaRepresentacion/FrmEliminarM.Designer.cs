namespace SintesisBase.CapaRepresentacion
{
    partial class FrmEliminarM
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
            this.txtME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.btnEM = new System.Windows.Forms.Button();
            this.btnCancelarCC = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtME
            // 
            this.txtME.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtME.Location = new System.Drawing.Point(150, 114);
            this.txtME.Name = "txtME";
            this.txtME.Size = new System.Drawing.Size(223, 29);
            this.txtME.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Proveedor:";
            // 
            // txtMID
            // 
            this.txtMID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMID.Location = new System.Drawing.Point(542, 114);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(92, 29);
            this.txtMID.TabIndex = 15;
            // 
            // btnEM
            // 
            this.btnEM.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEM.Location = new System.Drawing.Point(199, 206);
            this.btnEM.Name = "btnEM";
            this.btnEM.Size = new System.Drawing.Size(117, 36);
            this.btnEM.TabIndex = 19;
            this.btnEM.Text = "Eliminar";
            this.btnEM.UseVisualStyleBackColor = false;
            this.btnEM.Click += new System.EventHandler(this.btnEM_Click);
            // 
            // btnCancelarCC
            // 
            this.btnCancelarCC.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelarCC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarCC.Location = new System.Drawing.Point(456, 206);
            this.btnCancelarCC.Name = "btnCancelarCC";
            this.btnCancelarCC.Size = new System.Drawing.Size(104, 36);
            this.btnCancelarCC.TabIndex = 20;
            this.btnCancelarCC.Text = "Cancelar";
            this.btnCancelarCC.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Image = global::SintesisBase.Properties.Resources.basura_mas;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTitulo.Location = new System.Drawing.Point(306, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 25);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "ELIMINAR MARCA          ";
            // 
            // FrmEliminarM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 311);
            this.Controls.Add(this.btnCancelarCC);
            this.Controls.Add(this.btnEM);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtMID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtME);
            this.Name = "FrmEliminarM";
            this.Text = "FrmMarcaE";
            this.Load += new System.EventHandler(this.FrmEliminarM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEM;
        private System.Windows.Forms.Button btnCancelarCC;
    }
}