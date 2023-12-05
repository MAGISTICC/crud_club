namespace Club
{
    partial class CambiarContraseñaForm
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
            Button btnContinuar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContraseñaForm));
            txtCorreo = new TextBox();
            txtDNI = new TextBox();
            txtNuevaContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnContinuar = new Button();
            SuspendLayout();
            // 
            // btnContinuar
            // 
            btnContinuar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnContinuar.Location = new Point(12, 189);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(165, 48);
            btnContinuar.TabIndex = 6;
            btnContinuar.Text = "Cambiar Contraseña";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += btnContinuar_Click_1;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreo.Location = new Point(103, 36);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(233, 35);
            txtCorreo.TabIndex = 0;
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDNI.Location = new Point(71, 89);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(233, 35);
            txtDNI.TabIndex = 1;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNuevaContraseña.Location = new Point(216, 130);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(233, 35);
            txtNuevaContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 41);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 3;
            label1.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(53, 30);
            label2.TabIndex = 4;
            label2.Text = "Dni:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(198, 30);
            label3.TabIndex = 5;
            label3.Text = "Nueva Contraseña:";
            // 
            // CambiarContraseñaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnContinuar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNuevaContraseña);
            Controls.Add(txtDNI);
            Controls.Add(txtCorreo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CambiarContraseñaForm";
            Text = "CambiarContraseñaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtDNI;
        private TextBox txtNuevaContraseña;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}