using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMetodosF
{
    internal class InterLI
    {
        public static Tuple<double, double> LinearInterpolationLog(double x0, double x1, double log_x0, double log_x1, double x_target)
        {
            // Interpolación lineal para encontrar el logaritmo de x_target
            double log_x_target = log_x0 + (log_x1 - log_x0) * (x_target - x0) / (x1 - x0);

            // Valor verdadero del logaritmo natural de x_target
            double true_log_x_target = Math.Log(x_target);

            // Error relativo porcentual
            double error = Math.Abs(log_x_target - true_log_x_target) / Math.Abs(true_log_x_target) * 100;

            // Resultado y error
            return new Tuple<double, double>(log_x_target, error);
        }
    }
}
