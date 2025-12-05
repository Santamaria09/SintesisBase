namespace SintesisBase.CapaRepresentacion
{
    partial class FrmActualizarUsuario
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(127, 278);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(135, 57);
            this.btnActualizar.TabIndex = 0;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(302, 278);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 57);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACTUALIZAR USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(334, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(334, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(127, 130);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(166, 29);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(127, 217);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(166, 29);
            this.txtClave.TabIndex = 8;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(379, 130);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 29);
            this.cmbRol.TabIndex = 9;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.BackColor = System.Drawing.Color.White;
            this.chkEstado.Location = new System.Drawing.Point(399, 178);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(72, 25);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(334, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(399, 217);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(72, 29);
            this.txtId.TabIndex = 12;
            // 
            // FrmActualizarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 429);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmActualizarUsuario";
            this.Text = "FrmActualizarUsuario";
            this.Load += new System.EventHandler(this.FrmActualizarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
    }
}