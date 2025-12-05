namespace SintesisBase.CapaRepresentacion
{
    partial class FrmNuevoUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.cmbRol = new System.Windows.Forms.ComboBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGREGAR NUEVO USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(51, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(343, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(138, 312);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 50);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 312);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(131, 50);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(149, 146);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(152, 29);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(149, 231);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(152, 29);
            this.txtClave.TabIndex = 8;
            // 
            // cmbRol
            // 
            this.cmbRol.FormattingEnabled = true;
            this.cmbRol.Location = new System.Drawing.Point(414, 146);
            this.cmbRol.Name = "cmbRol";
            this.cmbRol.Size = new System.Drawing.Size(121, 29);
            this.cmbRol.TabIndex = 9;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.BackColor = System.Drawing.Color.White;
            this.chkEstado.Location = new System.Drawing.Point(420, 197);
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
            this.label6.Location = new System.Drawing.Point(343, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(414, 239);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(78, 29);
            this.txtId.TabIndex = 12;
            // 
            // FrmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 402);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.cmbRol);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNuevoUsuario";
            this.Text = "FrmNuevoUsuario";
            this.Load += new System.EventHandler(this.FrmNuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
    }
}