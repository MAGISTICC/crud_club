using MySql.Data.MySqlClient;
using System;

namespace Club
{
    internal class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "socios";
        private string user = "root";
        private string password = "";
        private string cadenaconex;

        public Conexion()
        {
            // Corregir la propiedad para especificar el servidor (debe ser 'Server' en lugar de 'DataSource')
            cadenaconex = "Server=" + server +
                "; Database=" + database +
                "; User Id=" + user +
                "; Password=" + password +
                ";";
        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaconex);
                conexion.Open();
            }

            return conexion;
        }
    }
}

