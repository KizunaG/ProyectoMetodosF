using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMetodosF
{
    public partial class InterpolacionLineal : Form
    {
        public InterpolacionLineal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar la entrada de datos
            if (!ValidarEntrada())
            {
                return;
            }

            try
            {
                // Obtener los valores de los cuadros de texto
                double x0 = double.Parse(txtX0.Text);
                double x1 = double.Parse(txtX1.Text);
                double log_x0 = double.Parse(txtLogX0.Text);
                double log_x1 = double.Parse(txtLogX1.Text);
                double x_target = double.Parse(txtXTarget.Text);

                // Llamar a la función de interpolación lineal
                var result = InterLI.LinearInterpolationLog(x0, x1, log_x0, log_x1, x_target);

                // Mostrar el resultado y el error en las etiquetas
                lblResult.Text = $"Resultado: {result.Item1}";
                lblError.Text = $"Error relativo porcentual: {result.Item2}%";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, asegúrate de ingresar números válidos en todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarEntrada()
        {
            // Validar que los campos no estén vacíos y contengan números válidos
            if (!double.TryParse(txtX0.Text, out double x0) ||
                !double.TryParse(txtX1.Text, out double x1) ||
                !double.TryParse(txtLogX0.Text, out double log_x0) ||
                !double.TryParse(txtLogX1.Text, out double log_x1) ||
                !double.TryParse(txtXTarget.Text, out double x_target))
            {
                MessageBox.Show("Por favor, asegúrate de ingresar números válidos en todos los campos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de texto
            txtX0.Text = "";
            txtX1.Text = "";
            txtLogX0.Text = "";
            txtLogX1.Text = "";
            txtXTarget.Text = "";

            // Limpiar las etiquetas de resultado
            lblResult.Text = "";
            lblError.Text = "";
        }
    }
    
}
