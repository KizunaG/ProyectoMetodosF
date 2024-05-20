using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodosF
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InterpolacionLineal InterLineForm = new InterpolacionLineal();
            InterLineForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MetodoMuller MetodoMuForm = new MetodoMuller();
            MetodoMuForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InterpolacionCuadratica InterCuaForm = new InterpolacionCuadratica();
            InterCuaForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalculoErrores CalculoErroForm = new CalculoErrores();
            CalculoErroForm.Show();
        }
    }
}
