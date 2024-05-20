using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMetodosF
{
    class InterCuadra
    {
        private double x0, x1, x2, f_x0, f_x1, f_x2, x_target;

        public InterCuadra(double x0, double x1, double x2, double f_x0, double f_x1, double f_x2, double x_target)
        {
            this.x0 = x0;
            this.x1 = x1;
            this.x2 = x2;
            this.f_x0 = f_x0;
            this.f_x1 = f_x1;
            this.f_x2 = f_x2;
            this.x_target = x_target;
        }

        public double[] RealizarInterpolacion()
        {
            // Coeficientes del polinomio de interpolación cuadrática
            double a = ((f_x2 - f_x1) / (x2 - x1) - (f_x1 - f_x0) / (x1 - x0)) / (x2 - x0);
            double b = (f_x1 - f_x0) / (x1 - x0) - a * (x1 + x0);
            double c = f_x0 - a * Math.Pow(x0, 2) - b * x0;

            // Evaluar el polinomio en x_target
            double result = a * Math.Pow(x_target, 2) + b * x_target + c;

            // Calcular el valor de la función en x_target
            double f_x_target = a * Math.Pow(x_target, 2) + b * x_target + c;

            // Valor verdadero de ln(2)
            double true_value = Math.Log(2); // El valor verdadero de ln(2)

            // Error relativo porcentual
            double error = Math.Abs((true_value - f_x_target) / true_value) * 100;

            return new double[] { result, error };
        }
    }
}

