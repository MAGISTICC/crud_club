using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Club
{
    public partial class Registro : Form
    {
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=socios;UID=root;PASSWORD=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        public Registro()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mensaje de depuración para verificar que se ejecuta el evento
                MessageBox.Show("Botón Insertar presionado.");

                cn.Open();
                string insertar = "INSERT INTO socio_futbol (DNI, Nombre, Apellido, Correo, Contraseña, Direccion) VALUES (@DNI, @Nombre, @Apellido, @Correo, @Contraseña, @Direccion)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);

                cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                // Debug: Display the SQL command text
                MessageBox.Show($"SQL Command: {cmd.CommandText}");

                cmd.ExecuteNonQuery();

                // Debug: Display a message after executing the query
                MessageBox.Show("Los datos fueron guardados correctamente en la base de datos.");

                // Agregar una nueva fila al DataGridView con los valores de los TextBox
                dataGridView1.Rows.Add(txtDNI.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtContraseña.Text, txtDireccion.Text);

                // Limpiar los TextBox después de la inserción
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }


        private void LimpiarTextBox()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            txtDireccion.Clear();
        }

        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Mensaje de depuración para verificar que se ejecuta el evento
                MessageBox.Show("Botón Insertar presionado.");

                cn.Open();
                string insertar = "INSERT INTO socio_futbol (DNI, Nombre, Apellido, Correo, Contraseña, Direccion) VALUES (@DNI, @Nombre, @Apellido, @Correo, @Contraseña, @Direccion)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);

                cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
                cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text);

                // Debug: Display the SQL command text
                MessageBox.Show($"SQL Command: {cmd.CommandText}");

                cmd.ExecuteNonQuery();

                // Debug: Display a message after executing the query
                MessageBox.Show("Los datos fueron guardados correctamente en la base de datos.");

                // Agregar una nueva fila al DataGridView con los valores de los TextBox
                dataGridView1.Rows.Add(txtDNI.Text, txtNombre.Text, txtApellido.Text, txtCorreo.Text, txtContraseña.Text, txtDireccion.Text);

                // Limpiar los TextBox después de la inserción
                LimpiarTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

