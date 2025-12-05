namespace SintesisBase.CapaRepresentacion
{
    partial class FrmCambiarClave
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
            this.txtClaveActual = new System.Windows.Forms.TextBox();
            this.txtNuevaClave = new System.Windows.Forms.TextBox();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAMBIAR CONTRASEÑA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña actual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nueva contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar contraseña:";
            // 
            // txtClaveActual
            // 
            this.txtClaveActual.Location = new System.Drawing.Point(296, 148);
            this.txtClaveActual.Name = "txtClaveActual";
            this.txtClaveActual.Size = new System.Drawing.Size(179, 29);
            this.txtClaveActual.TabIndex = 4;
            // 
            // txtNuevaClave
            // 
            this.txtNuevaClave.Location = new System.Drawing.Point(296, 216);
            this.txtNuevaClave.Name = "txtNuevaClave";
            this.txtNuevaClave.Size = new System.Drawing.Size(179, 29);
            this.txtNuevaClave.TabIndex = 5;
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.Location = new System.Drawing.Point(296, 293);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Size = new System.Drawing.Size(179, 29);
            this.txtConfirmar.TabIndex = 6;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(122, 396);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(147, 51);
            this.btnCambiar.TabIndex = 7;
            this.btnCambiar.Text = "Actualizar contraseña";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 396);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 51);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 495);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.txtNuevaClave);
            this.Controls.Add(this.txtClaveActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCambiarClave";
            this.Text = "FrmCambiarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Button btnCancelar;
    }
}