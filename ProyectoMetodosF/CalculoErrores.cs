using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoMetodosF
{
    public partial class MetodoNewton : Form
    {
        public MetodoNewton()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados por el usuario
                double longitudPuenteVerdadera = double.Parse(longitudPuenteVerdaderaTextBox.Text);
                double longitudPuenteMedida = double.Parse(longitudPuenteMedidaTextBox.Text);
                double longitudRemacheVerdadera = double.Parse(longitudRemacheVerdaderaTextBox.Text);
                double longitudRemacheMedida = double.Parse(longitudRemacheMedidaTextBox.Text);

                // Calcular los errores para el puente
                double errorVerdaderoPuente = longitudPuenteVerdadera - longitudPuenteMedida;
                double errorRelativoPuente = (errorVerdaderoPuente / longitudPuenteVerdadera) * 100;

                // Calcular los errores para el remache
                double errorVerdaderoRemache = longitudRemacheVerdadera - longitudRemacheMedida;
                double errorRelativoRemache = (errorVerdaderoRemache / longitudRemacheVerdadera) * 100;

                // Mostrar los resultados
                errorPuenteLabel.Text = "Error verdadero del puente: " + errorVerdaderoPuente.ToString("F2") + " cm";
                errorRelativoPuenteLabel.Text = "Error relativo porcentual del puente: " + errorRelativoPuente.ToString("F2") + "%";
                errorRemacheLabel.Text = "Error verdadero del remache: " + errorVerdaderoRemache.ToString("F2") + " cm";
                errorRelativoRemacheLabel.Text = "Error relativo porcentual del remache: " + errorRelativoRemache.ToString("F2") + "%";
                mensajeLabel.Text = ""; // Limpiar cualquier mensaje de error previo
            }
            catch (Exception ex)
            {
                mensajeLabel.Text = "Error: " + ex.Message;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            longitudPuenteVerdaderaTextBox.Text = "";
            longitudPuenteMedidaTextBox.Text = "";
            longitudRemacheVerdaderaTextBox.Text = "";
            longitudRemacheMedidaTextBox.Text = "";
            errorPuenteLabel.Text = "";
            errorRelativoPuenteLabel.Text = "";
            errorRemacheLabel.Text = "";
            errorRelativoRemacheLabel.Text = "";
        }
    }
}
