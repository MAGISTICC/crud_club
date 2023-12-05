namespace Club
{
    partial class IniSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniSesion));
            btnIniciarSesion = new Button();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCambiarContraseña = new Button();
            SuspendLayout();
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.BackColor = Color.White;
            btnIniciarSesion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnIniciarSesion.Location = new Point(12, 184);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(190, 52);
            btnIniciarSesion.TabIndex = 0;
            btnIniciarSesion.Text = "Iniciar Sesion";
            btnIniciarSesion.UseVisualStyleBackColor = false;
            btnIniciarSesion.Click += btnIniciarSesion_Click_1;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreo.Location = new Point(103, 12);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(333, 35);
            txtCorreo.TabIndex = 1;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.Location = new Point(147, 91);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(333, 35);
            txtContraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 3;
            label1.Text = "Correo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(129, 30);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCambiarContraseña.Location = new Point(248, 184);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(223, 52);
            btnCambiarContraseña.TabIndex = 5;
            btnCambiarContraseña.Text = "Cambiar Contraseña";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // IniSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(btnIniciarSesion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IniSesion";
            Text = "IniSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarSesion;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private Label label1;
        private Label label2;
        private Button btnCambiarContraseña;
    }
}