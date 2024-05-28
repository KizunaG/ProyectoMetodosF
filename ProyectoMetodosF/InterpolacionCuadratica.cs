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
    public partial class MetodoGauss : Form
    {
        public MetodoGauss()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
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
