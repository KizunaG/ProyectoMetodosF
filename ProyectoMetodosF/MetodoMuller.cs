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
    public partial class MetodoMuller : Form
    {
        private string connectionString = "Data source=LAPTOP-IUQ31NPB\\SQLEXPRESS; Initial Catalog=ProyectoMetodos; Integrated security=true;";
        public MetodoMuller()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string funcion = txtFuncion.Text;

                if (!double.TryParse(txtx0.Text, out double x0))
                {
                    MessageBox.Show("Valor de x0 no válido");
                    return;
                }

                if (!double.TryParse(txtx1.Text, out double x1))
                {
                    MessageBox.Show("Valor de x1 no válido");
                    return;
                }

                if (!double.TryParse(txtx2.Text, out double x2))
                {
                    MessageBox.Show("Valor de x2 no válido");
                    return;
                }

                if (!double.TryParse(txtTolerancia.Text, out double tolerancia))
                {
                    MessageBox.Show("Valor de tolerancia no válido");
                    return;
                }

                if (!int.TryParse(txtMaxiter.Text, out int maxIter))
                {
                    MessageBox.Show("Valor de iteraciones máximas no válido");
                    return;
                }

                if (!ValidarFuncion(funcion))
                {
                    MessageBox.Show("Función no válida. Asegúrate de que la función sea correcta.");
                    return;
                }

                var iteraciones = new List<(int iteracion, double xr, double error)>();

                double h0 = x1 - x0;
                double h1 = x2 - x1;

                for (int i = 0; i < maxIter; i++)
                {
                    // Evaluar la función en x0, x1, x2
                    double f0 = EvaluarFuncion(funcion, x0);
                    double f1 = EvaluarFuncion(funcion, x1);
                    double f2 = EvaluarFuncion(funcion, x2);

                    // Calcular las diferencias divididas
                    double delta1 = (f1 - f0) / h0;
                    double delta2 = (f2 - f1) / h1;
                    double lambda = (delta2 - delta1) / (h1 + h0);

                    // Calcular las constantes de la ecuación cuadrática
                    double a = lambda;
                    double b = lambda * h1 + delta2;
                    double c = f2;

                    // Calcular el discriminante
                    double discriminante = Math.Sqrt(b * b - 4 * a * c);

                    // Elegir el denominador con la mayor magnitud
                    double denominador = Math.Abs(b + Math.Sign(b) * discriminante) > Math.Abs(b - Math.Sign(b) * discriminante)
                        ? b + Math.Sign(b) * discriminante : b - Math.Sign(b) * discriminante;

                    // Calcular la nueva aproximación
                    double dxr = -2 * c / denominador;
                    double xr = x2 + dxr;

                    // Calcular el error relativo
                    double error = Math.Abs((xr - x2) / xr) * 100;

                    // Almacenar la iteración en la lista
                    iteraciones.Add((i + 1, xr, error));

                    // Comprobar la tolerancia
                    if (error < tolerancia)
                        break;

                    // Actualizar los valores para la siguiente iteración
                    x0 = x1;
                    x1 = x2;
                    x2 = xr;
                    h0 = x1 - x0;
                    h1 = x2 - x1;
                }

                // Insertar los resultados en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertCalculoQuery = "INSERT INTO Calculo DEFAULT VALUES; SELECT SCOPE_IDENTITY();";
                    SqlCommand calculoCommand = new SqlCommand(insertCalculoQuery, connection);
                    int calculoId = Convert.ToInt32(calculoCommand.ExecuteScalar());

                    foreach (var iter in iteraciones)
                    {
                        string query = "INSERT INTO MetodoMuller (calculo_id, iteracion, xr, error) VALUES (@calculo_id, @iteracion, @xr, @error)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@calculo_id", calculoId);
                            command.Parameters.AddWithValue("@iteracion", iter.iteracion);
                            command.Parameters.AddWithValue("@xr", iter.xr);
                            command.Parameters.AddWithValue("@error", iter.error);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                // Cargar y mostrar los resultados en el DataGridView
                CargarDatosDesdeSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private double EvaluarFuncion(string funcion, double x)
        {
            try
            {
                var expression = new Expression(funcion);
                expression.Parameters["x"] = x;
                return Convert.ToDouble(expression.Evaluate());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al evaluar la función: " + ex.Message);
                throw;
            }
        }

        private bool ValidarFuncion(string funcion)
        {
            try
            {
                var expression = new Expression(funcion);
                expression.Parameters["x"] = 1; // Prueba con un valor arbitrario
                var result = expression.Evaluate();
                return true;
            }
            catch
            {
                return false;
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
                    string query = "SELECT iteracion, xr, error FROM MetodoMuller WHERE calculo_id = (SELECT MAX(id) FROM Calculo)";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewResultadoMuller.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save a PDF File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    PdfPTable table = new PdfPTable(dataGridViewResultadoMuller.Columns.Count);

                    // Agregar encabezados
                    foreach (DataGridViewColumn column in dataGridViewResultadoMuller.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }

                    // Agregar filas
                    foreach (DataGridViewRow row in dataGridViewResultadoMuller.Rows)
                    {
                        if (row.IsNewRow) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                        }
                    }

                    pdfDoc.Add(table);
                    pdfDoc.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFuncion.Clear();
            txtx0.Clear();
            txtx1.Clear();
            txtx2.Clear();
            txtTolerancia.Clear();
            txtMaxiter.Clear();
            dataGridViewResultadoMuller.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


    

