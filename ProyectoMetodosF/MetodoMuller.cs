using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jace;
using NCalc;

namespace ProyectoMetodosF
{
    public partial class MetodoMuller : Form
    {
        public MetodoMuller()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string function = txtFunction.Text;
                double x0 = Convert.ToDouble(txtX0.Text);
                double x1 = Convert.ToDouble(txtX1.Text);
                double x2 = Convert.ToDouble(txtX2.Text);

                txtResult.Clear();
                txtResult.AppendText("Iteración\tRaíz\t\tError relativo\n");

                double tol = 1e-6;
                int maxIter = 1000;
                double previousRoot = x2;

                for (int i = 0; i < maxIter; i++)
                {
                    double result = MullerMethod(function, x0, x1, x2, tol);
                    double error = Math.Abs((result - previousRoot) / result) * 100;

                    txtResult.AppendText($"{i}\t\t{result:F6}\t{error:F6}%\n");

                    if (Math.Abs(result - previousRoot) < tol)
                    {
                        txtResult.AppendText("Se alcanzó la tolerancia deda.\n");
                        return;
                    }

                    previousRoot = result;
                    x0 = x1;
                    x1 = x2;
                    x2 = result;
                }

                txtResult.AppendText("Se alcanzó el máximo de iteraciones.\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double MullerMethod(string function, double x0, double x1, double x2, double tol)
        {
            Func<double, double> f = (x) => EvaluateFunction(function, x);

            for (int i = 0; i < 1000; i++) // Número máximo de iteraciones
            {
                double h1 = x1 - x0;
                double h2 = x2 - x1;
                double δ1 = (f(x1) - f(x0)) / h1;
                double δ2 = (f(x2) - f(x1)) / h2;
                double d = (δ2 - δ1) / (h2 + h1);

                double b = δ2 + h2 * d;
                double D = Math.Sqrt(b * b - 4 * f(x2) * d);
                double E = (Math.Abs(b + D) > Math.Abs(b - D)) ? b + D : b - D;

                double h = -2 * f(x2) / E;
                double x3 = x2 + h;

                if (Math.Abs(h) < tol)
                {
                    return x3;
                }

                x0 = x1;
                x1 = x2;
                x2 = x3;
            }

            throw new Exception("No se encontró raíz en las iteraciones máximas permitidas.");
        }

        private double EvaluateFunction(string function, double x)
        {
            try
            {
                CalculationEngine engine = new CalculationEngine();
                var variables = new Dictionary<string, double> { { "x", x } };
                return engine.Calculate(function, variables);
            }
            catch
            {
                throw new Exception("No se pudo evaluar la función correctamente.");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
