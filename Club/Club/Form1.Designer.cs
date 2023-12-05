namespace Club
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btnRegistro;
            Button btnInicioS;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnRegistro = new Button();
            btnInicioS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnRegistro
            // 
            btnRegistro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistro.Location = new Point(12, 199);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(138, 46);
            btnRegistro.TabIndex = 0;
            btnRegistro.Text = "Registro";
            btnRegistro.UseVisualStyleBackColor = true;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // btnInicioS
            // 
            btnInicioS.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInicioS.Location = new Point(612, 199);
            btnInicioS.Name = "btnInicioS";
            btnInicioS.Size = new Size(176, 46);
            btnInicioS.TabIndex = 1;
            btnInicioS.Text = "Iniciar Sesion";
            btnInicioS.UseVisualStyleBackColor = true;
            btnInicioS.Click += btnInicioS_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(319, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 327);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnInicioS);
            Controls.Add(btnRegistro);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistro;
        private Button btnInicioS;
        private PictureBox pictureBox1;
    }
}