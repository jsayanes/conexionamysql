using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conexionamysql
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string servidor = "localhost";
            string puerto = "3308";
            string usuario = "root";
            string password = "root";
            string bdatos = "Productosa";

            string cadenaconexionMysql = "Database=" + bdatos + "; Data Source=" + servidor + "; Port=" + puerto + "; User Id=" + usuario + "; Password=" + password;

            MySqlConnection conexionBD = new MySqlConnection(cadenaconexionMysql);
            MySqlDataReader reader = null;

            string data = null;

            try
            {
                string consulta = "SHOW DATABASES";
                MySqlCommand comando = new MySqlCommand(consulta);
                comando.Connection = conexionBD;
                conexionBD.Open();
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    data += reader.GetString(0) + "\n";
                }
                MessageBox.Show(data);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error: " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }







        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
