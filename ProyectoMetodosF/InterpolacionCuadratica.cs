using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using NCalc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace ProyectoMetodosF
{
    public partial class MetodoGauss : Form
    {
        private string connectionString = "Data source=LAPTOP-IUQ31NPB\\SQLEXPRESS; Initial Catalog=ProyectoMetodos; Integrated security=true;";
        public MetodoGauss()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener los valores ingresados por el usuario
                double[,] matrizCoeficientes = ObtenerMatrizCoeficientes();
                double[] vectorIndependiente = ObtenerVectorIndependiente();

                // Resolver el sistema de ecuaciones usando el método de Gauss
                double[] soluciones = MetodoGausss(matrizCoeficientes, vectorIndependiente);

                // Insertar los resultados en la base de datos
                InsertarResultadosEnDB(soluciones);

                // Cargar y mostrar los resultados en el DataGridView
                CargarDatosDesdeSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double[,] ObtenerMatrizCoeficientes()
        {
            double[,] matrizCoeficientes = new double[3, 3]; // Suponiendo una matriz de 3x3

            // Ingresar los valores de la matriz desde los TextBox
            matrizCoeficientes[0, 0] = double.Parse(txtCoeficiente11.Text);
            matrizCoeficientes[0, 1] = double.Parse(txtCoeficiente12.Text);
            matrizCoeficientes[0, 2] = double.Parse(txtCoeficiente13.Text);
            matrizCoeficientes[1, 0] = double.Parse(txtCoeficiente21.Text);
            matrizCoeficientes[1, 1] = double.Parse(txtCoeficiente22.Text);
            matrizCoeficientes[1, 2] = double.Parse(txtCoeficiente23.Text);
            matrizCoeficientes[2, 0] = double.Parse(txtCoeficiente31.Text);
            matrizCoeficientes[2, 1] = double.Parse(txtCoeficiente32.Text);
            matrizCoeficientes[2, 2] = double.Parse(txtCoeficiente33.Text);

            return matrizCoeficientes;
        }

        private double[] ObtenerVectorIndependiente()
        {
            double[] vectorIndependiente = new double[3]; // Suponiendo un vector de 3 elementos

            // Ingresar los valores del vector desde los TextBox
            vectorIndependiente[0] = double.Parse(txtIndependiente1.Text);
            vectorIndependiente[1] = double.Parse(txtIndependiente2.Text);
            vectorIndependiente[2] = double.Parse(txtIndependiente3.Text);

            return vectorIndependiente;
        }

        private double[] MetodoGausss(double[,] matrizCoeficientes, double[] vectorIndependiente)
        {
            int n = vectorIndependiente.Length;
            double[] soluciones = new double[n];

            // Eliminación hacia adelante
            for (int k = 0; k < n - 1; k++)
            {
                for (int i = k + 1; i < n; i++)
                {
                    double factor = matrizCoeficientes[i, k] / matrizCoeficientes[k, k];
                    for (int j = k; j < n; j++)
                    {
                        matrizCoeficientes[i, j] -= factor * matrizCoeficientes[k, j];
                    }
                    vectorIndependiente[i] -= factor * vectorIndependiente[k];
                }
            }

            // Sustitución hacia atrás
            for (int i = n - 1; i >= 0; i--)
            {
                double suma = 0;
                for (int j = i + 1; j < n; j++)
                {
                    suma += matrizCoeficientes[i, j] * soluciones[j];
                }
                soluciones[i] = (vectorIndependiente[i] - suma) / matrizCoeficientes[i, i];
            }

            return soluciones;
        }

        private void InsertarResultadosEnDB(double[] soluciones)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear un nuevo registro en la tabla Calculo
                string insertCalculoQuery = "INSERT INTO Calculo DEFAULT VALUES; SELECT SCOPE_IDENTITY();";
                SqlCommand calculoCommand = new SqlCommand(insertCalculoQuery, connection);
                int calculoId = Convert.ToInt32(calculoCommand.ExecuteScalar());

                for (int i = 0; i < soluciones.Length; i++)
                {
                    string query = "INSERT INTO MetodoGauss (calculo_id, iteracion, x" + (i + 1) + ") VALUES (@calculo_id, @iteracion, @x)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@calculo_id", calculoId);
                        command.Parameters.AddWithValue("@iteracion", 1); // En este caso, solo una iteración
                        command.Parameters.AddWithValue("@x", soluciones[i]);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void CargarDatosDesdeSQL()
        {
            try
            {
                dataGridViewResultadoMuller.DataSource = null; // Limpiar el DataGridView antes de cargar nuevos datos

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM MetodoGauss WHERE calculo_id = (SELECT MAX(id) FROM Calculo)"; // Ajusta la consulta según tu tabla y necesidades
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewResultadoMuller.DataSource = dataTable;
                    
                    // Ocultar la columna ID
                    if (dataGridViewResultadoMuller.Columns["ID"] != null)
                    {
                        dataGridViewResultadoMuller.Columns["ID"].Visible = false;
                    }

                    // Ocultar la columna ID
                    if (dataGridViewResultadoMuller.Columns["Iteracion"] != null)
                    {
                        dataGridViewResultadoMuller.Columns["Iteracion"].Visible = false;
                    }

                    // Ocultar la columna calculo_id
                    if (dataGridViewResultadoMuller.Columns["calculo_id"] != null)
                    {
                        dataGridViewResultadoMuller.Columns["calculo_id"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewResultadoMuller.DataSource = null;
            dataGridViewResultadoMuller.Rows.Clear();
            dataGridViewResultadoMuller.Columns.Clear();
            dataGridViewResultadoMuller.Refresh();
            txtCoeficiente11.Clear();
            txtCoeficiente12.Clear();
            txtCoeficiente13.Clear();
            txtCoeficiente21.Clear();
            txtCoeficiente22.Clear();
            txtCoeficiente23.Clear();
            txtCoeficiente31.Clear();
            txtCoeficiente32.Clear();
            txtCoeficiente33.Clear();
            txtIndependiente1.Clear();
            txtIndependiente2.Clear();
            txtIndependiente3.Clear();


        }
    }
}



