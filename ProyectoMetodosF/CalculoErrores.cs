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
    public partial class MetodoNewton : Form
    {
        private string connectionString = "Data source=LAPTOP-IUQ31NPB\\SQLEXPRESS; Initial Catalog=ProyectoMetodos; Integrated security=true;";
        public MetodoNewton()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string funcion = txtFuncion.Text;

                if (!double.TryParse(txtx0.Text, out double x0))
                {
                    MessageBox.Show("Valor de x0 no válido");
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

                for (int i = 0; i < maxIter; i++)
                {
                    double fx = EvaluarFuncion(funcion, x0);
                    double dfx = CalcularDerivada(funcion, x0);

                    if (dfx == 0)
                    {
                        MessageBox.Show("Derivada igual a cero. No se puede continuar.");
                        return;
                    }

                    double xr = x0 - fx / dfx;
                    double error = Math.Abs(xr - x0)/xr * 100;

                    iteraciones.Add((i + 1, xr, error));

                    if (error < tolerancia)
                        break;

                    x0 = xr;
                }

                // Insertar los resultados en la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    int calculoId;
                    using (SqlCommand command = new SqlCommand("INSERT INTO Calculo OUTPUT INSERTED.id VALUES (DEFAULT)", connection))
                    {
                        calculoId = (int)command.ExecuteScalar();
                    }

                    foreach (var iter in iteraciones)
                    {
                        string query = "INSERT INTO MetodoNewtonRaphson(calculo_id, iteracion, xr, error) VALUES (@calculo_id, @iteracion, @xr, @error)";
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

        private double CalcularDerivada(string funcion, double x)
        {
            double h = 1e-9; // Tamaño del paso para la aproximación de la derivada
            double fxph = EvaluarFuncion(funcion, x + h);
            double fxmh = EvaluarFuncion(funcion, x - h);
            return (fxph - fxmh) / (2 * h);
        }

        private bool ValidarFuncion(string funcion)
        {
            try
            {
                var expression = new Expression(funcion);
                expression.Parameters["x"] = 1;
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
                dataGridViewResultadoNewtonRaphson.DataSource = null; // Limpiar el DataGridView antes de cargar nuevos datos

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT iteracion, xr, error FROM MetodoNewtonRaphson WHERE calculo_id = (SELECT MAX(id) FROM Calculo)";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewResultadoNewtonRaphson.DataSource = dataTable;
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

                    PdfPTable table = new PdfPTable(dataGridViewResultadoNewtonRaphson.Columns.Count);

                    foreach (DataGridViewColumn column in dataGridViewResultadoNewtonRaphson.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }

                    foreach (DataGridViewRow row in dataGridViewResultadoNewtonRaphson.Rows)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridViewResultadoNewtonRaphson.DataSource = null;
            dataGridViewResultadoNewtonRaphson.Rows.Clear();
            dataGridViewResultadoNewtonRaphson.Columns.Clear();
            dataGridViewResultadoNewtonRaphson.Refresh();
            txtFuncion.Clear();
            txtx0.Clear();
            txtTolerancia.Clear();
            txtMaxiter.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
