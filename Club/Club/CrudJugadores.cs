using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Club
{
    public partial class CrudJugadores : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=socios;User=root;Password=;";
        private MySqlConnection connection;

        public CrudJugadores()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }

        private void TuFormulario_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            string query = "SELECT * FROM jugadores";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
            {
                // Insertar en la base de datos
                string insertQuery = "INSERT INTO jugadores (Nombre, Apellido) VALUES (@Nombre, @Apellido)";
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Nombre", nombre);
                    insertCommand.Parameters.AddWithValue("@Apellido", apellido);

                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    connection.Close();
                }

                // Recargar los datos en la DataGridView
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener el valor de la clave primaria
                    int primaryKeyValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    // Obtener los nuevos valores después de la edición en la DataGridView
                    string nuevoNombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    string nuevoApellido = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();

                    Console.WriteLine($"Modificando fila con ID: {primaryKeyValue}, Nuevo Nombre: {nuevoNombre}, Nuevo Apellido: {nuevoApellido}");

                    // Actualizar en la base de datos
                    string updateQuery = "UPDATE jugadores SET Nombre = @NuevoNombre, Apellido = @NuevoApellido WHERE ID = @ID";
                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                        updateCommand.Parameters.AddWithValue("@NuevoApellido", nuevoApellido);
                        updateCommand.Parameters.AddWithValue("@ID", primaryKeyValue);

                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }

                        updateCommand.ExecuteNonQuery();
                    }

                    // Recargar los datos en la DataGridView
                    CargarDatos();
                    Console.WriteLine("Datos recargados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Conexión cerrada.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria
                int primaryKeyValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Borrar en la base de datos
                string deleteQuery = "DELETE FROM jugadores WHERE ID = @ID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@ID", primaryKeyValue);

                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    connection.Close();
                }

                // Recargar los datos en la DataGridView
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
            {
                // Insertar en la base de datos
                string insertQuery = "INSERT INTO jugadores (Nombre, Apellido) VALUES (@Nombre, @Apellido)";
                using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@Nombre", nombre);
                    insertCommand.Parameters.AddWithValue("@Apellido", apellido);

                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    connection.Close();
                }

                // Recargar los datos en la DataGridView
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener el valor de la clave primaria
                    int primaryKeyValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                    // Obtener los nuevos valores después de la edición en la DataGridView
                    string nuevoNombre = dataGridView1.SelectedRows[0].Cells["Nombre"].Value.ToString();
                    string nuevoApellido = dataGridView1.SelectedRows[0].Cells["Apellido"].Value.ToString();

                    Console.WriteLine($"Modificando fila con ID: {primaryKeyValue}, Nuevo Nombre: {nuevoNombre}, Nuevo Apellido: {nuevoApellido}");

                    // Actualizar en la base de datos
                    string updateQuery = "UPDATE jugadores SET Nombre = @NuevoNombre, Apellido = @NuevoApellido WHERE ID = @ID";

                    // Verificar si la conexión está abierta antes de intentar abrir nuevamente
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@NuevoNombre", nuevoNombre);
                        updateCommand.Parameters.AddWithValue("@NuevoApellido", nuevoApellido);
                        updateCommand.Parameters.AddWithValue("@ID", primaryKeyValue);

                        updateCommand.ExecuteNonQuery();
                    }

                    // Recargar los datos en la DataGridView
                    CargarDatos();
                    Console.WriteLine("Datos recargados correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al modificar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Solo cierra la conexión si fue abierta en este método
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                        Console.WriteLine("Conexión cerrada.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el valor de la clave primaria
                int primaryKeyValue = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID"].Value);

                // Borrar en la base de datos
                string deleteQuery = "DELETE FROM jugadores WHERE ID = @ID";
                using (MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCommand.Parameters.AddWithValue("@ID", primaryKeyValue);

                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    connection.Close();
                }

                // Recargar los datos en la DataGridView
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrudJugadores_Load(object sender, EventArgs e)
        {
            CargarDatos();

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
