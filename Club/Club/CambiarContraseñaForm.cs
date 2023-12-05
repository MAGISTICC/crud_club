using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Club
{
    public partial class CambiarContraseñaForm : Form
    {
        // La cadena de conexión a la base de datos
        private string connectionString = "Server=127.0.0.1;Database=socios;User=root;Password=;";
        private bool contraseñaActualizada = false;

        public CambiarContraseñaForm()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string dni = txtDNI.Text;
            string nuevaContraseña = txtNuevaContraseña.Text;

            // Validar campos vacíos
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar usuario en la base de datos
            if (VerificarUsuarioEnBaseDeDatos(correo, dni))
            {
                // Actualizar contraseña en la base de datos
                ActualizarContraseñaEnBaseDeDatos(correo, nuevaContraseña);
                MessageBox.Show("Contraseña cambiada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contraseñaActualizada = true;

                // Volver al formulario de inicio de sesión
                IniSesion inicioSesionForm = new IniSesion();
                inicioSesionForm.Show();

                this.Close();  // Cierra el formulario actual si es necesario
            }
            else
            {
                MessageBox.Show("Usuario no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool VerificarUsuarioEnBaseDeDatos(string correo, string dni)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Verificar si el usuario existe en la base de datos
                string query = "SELECT COUNT(*) FROM socio_futbol WHERE Correo = @Correo OR DNI = @DNI";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@DNI", dni);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void ActualizarContraseñaEnBaseDeDatos(string correo, string nuevaContraseña)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Actualizar la contraseña en la base de datos
                string query = "UPDATE socio_futbol SET Contraseña = @Contraseña WHERE Correo = @Correo";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Contraseña", nuevaContraseña);
                    command.Parameters.AddWithValue("@Correo", correo);

                    command.ExecuteNonQuery();
                }
            }
        }

        private void btnContinuar_Click_1(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string dni = txtDNI.Text;
            string nuevaContraseña = txtNuevaContraseña.Text;

            // Validar campos vacíos
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(dni))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar usuario en la base de datos
            if (VerificarUsuarioEnBaseDeDatos(correo, dni))
            {
                // Actualizar contraseña en la base de datos
                ActualizarContraseñaEnBaseDeDatos(correo, nuevaContraseña);
                MessageBox.Show("Contraseña cambiada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                contraseñaActualizada = true;

                // Volver al formulario de inicio de sesión
                IniSesion inicioSesionForm = new IniSesion();
                inicioSesionForm.Show();

                this.Close();  // Cierra el formulario actual si es necesario
            }
            else
            {
                MessageBox.Show("Usuario no encontrado en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

