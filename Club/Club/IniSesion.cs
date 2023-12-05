using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Club
{
    public partial class IniSesion : Form
    {
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=socios;UID=root;PASSWORD=;";
        MySqlConnection cn = new MySqlConnection(conexion);

        public IniSesion()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT DNI FROM socio_futbol WHERE Correo = @Correo AND Contraseña = @Contraseña";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)  // Si se encuentra un DNI correspondiente a las credenciales
                {
                    string dni = result.ToString();

                    MessageBox.Show($"Inicio de sesión exitoso para el DNI: {dni}");

                    // Abrir el formulario CrudJugadores
                    CrudJugadores crudJugadoresForm = new CrudJugadores();
                    crudJugadoresForm.Show();

                    // O puedes cerrar el formulario actual si es necesario
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarContraseñaForm cambiarContraseñaForm = new CambiarContraseñaForm();
            cambiarContraseñaForm.ShowDialog();
        }

        private void btnIniciarSesion_Click_1(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                string query = "SELECT DNI FROM socio_futbol WHERE Correo = @Correo AND Contraseña = @Contraseña";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                object result = cmd.ExecuteScalar();

                if (result != null)  // Si se encuentra un DNI correspondiente a las credenciales
                {
                    string dni = result.ToString();

                    MessageBox.Show($"Inicio de sesión exitoso para el DNI: {dni}");

                    // Abrir el formulario CrudJugadores
                    CrudJugadores crudJugadoresForm = new CrudJugadores();
                    crudJugadoresForm.Show();

                    // O puedes cerrar el formulario actual si es necesario
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Correo o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar sesión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

