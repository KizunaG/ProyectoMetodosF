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
    public partial class InterpolacionCuadratica : Form
    {
        public InterpolacionCuadratica()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener valores del usuario
                double x0 = double.Parse(x0TextBox.Text);
                double x1 = double.Parse(x1TextBox.Text);
                double x2 = double.Parse(x2TextBox.Text);
                double f_x0 = double.Parse(f_x0TextBox.Text);
                double f_x1 = double.Parse(f_x1TextBox.Text);
                double f_x2 = double.Parse(f_x2TextBox.Text);
                double x_target = double.Parse(xTargetTextBox.Text);

                // Crear el interpolador cuadrático
                InterCuadra interpolador = new InterCuadra(x0, x1, x2, f_x0, f_x1, f_x2, x_target);

                // Realizar la interpolación
                double[] resultado = interpolador.RealizarInterpolacion();

                // Mostrar resultados
                resultLabel.Text = "Estimación de f(2): " + resultado[0].ToString("F7");
                errorLabel.Text = "Error relativo porcentual: " + resultado[1].ToString("F1") + "%";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            x0TextBox.Text = "";
            x1TextBox.Text = "";
            x2TextBox.Text = "";
            f_x0TextBox.Text = "";
            f_x1TextBox.Text = "";
            f_x2TextBox.Text = "";
            xTargetTextBox.Text = "";

            resultLabel.Text = "";
            errorLabel.Text = "";
        }
    }
}
