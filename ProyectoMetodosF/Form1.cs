using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ProyectoMetodosF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server=MSI\\SQLEXPRESS;database=usuario;integrated security=true");
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = "SELECT * from usuario where usuario='" + txtUsuario.Text + "' and contraseña= '" + txtContraseña.Text + "'";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if (lector.HasRows == true)
            {
                Inicio frmbienvenido = new Inicio();
                this.Hide();
                frmbienvenido.Show();
            }
            else
            {
                MessageBox.Show("Datos Invalidos");
            }
            conexion.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
