namespace Club
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            txtContraseña = new TextBox();
            txtDireccion = new TextBox();
            btnInsertar = new Button();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Miriam CLM", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(48, 23);
            label1.TabIndex = 0;
            label1.Text = ":DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(96, 24);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 96);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 2;
            label3.Text = "Apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(13, 137);
            label4.Name = "label4";
            label4.Size = new Size(85, 30);
            label4.TabIndex = 3;
            label4.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 178);
            label5.Name = "label5";
            label5.Size = new Size(129, 30);
            label5.TabIndex = 4;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(13, 219);
            label6.Name = "label6";
            label6.Size = new Size(111, 30);
            label6.TabIndex = 5;
            label6.Text = "Direccion:";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDNI.Location = new Point(148, 9);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(217, 35);
            txtDNI.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtNombre.Location = new Point(148, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(217, 35);
            txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtApellido.Location = new Point(148, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(217, 35);
            txtApellido.TabIndex = 8;
            // 
            // txtCorreo
            // 
            txtCorreo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCorreo.Location = new Point(148, 132);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(217, 35);
            txtCorreo.TabIndex = 9;
            // 
            // txtContraseña
            // 
            txtContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtContraseña.Location = new Point(148, 173);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(217, 35);
            txtContraseña.TabIndex = 10;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtDireccion.Location = new Point(148, 214);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(217, 35);
            txtDireccion.TabIndex = 11;
            // 
            // btnInsertar
            // 
            btnInsertar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsertar.Location = new Point(13, 281);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(164, 43);
            btnInsertar.TabIndex = 12;
            btnInsertar.Text = "Registrarse";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Correo });
            dataGridView1.Location = new Point(446, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(342, 312);
            dataGridView1.TabIndex = 13;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnInsertar);
            Controls.Add(txtDireccion);
            Controls.Add(txtContraseña);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtDNI);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registro";
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TextBox txtContraseña;
        private TextBox txtDireccion;
        private Button btnInsertar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Correo;
    }
}