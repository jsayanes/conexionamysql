using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexionamysql
{
    class ConexionMysql : Conexion
    {
        private MySqlConnection connection;
        private string cadenaConexion;

        public ConexionMysql()
        {

            cadenaConexion = "Database=" + bd + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection GetConnection()
        {

            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    MessageBox.Show("Conexion OK");

                }

            }

            catch (Exception ex)
            {

                MessageBox.Show("Error"+ex);

            }

            return connection;

        }

    }


}
