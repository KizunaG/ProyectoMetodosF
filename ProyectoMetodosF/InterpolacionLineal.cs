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
    public partial class MetodoSecante : Form
    {
        private string connectionString = "Data source=LAPTOP-IUQ31NPB\\SQLEXPRESS; Initial Catalog=ProyectoMetodos; Integrated security=true;";
        public MetodoSecante()
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
                    double fx0 = EvaluarFuncion(funcion, x0);
                    double fx1 = EvaluarFuncion(funcion, x1);

                    if (fx1 == fx0)
                    {
                        MessageBox.Show("División por cero detectada. No se puede continuar.");
                        return;
                    }

                    double xr = x1 - fx1 * (x1 - x0) / (fx1 - fx0);
                    double error = Math.Abs(xr - x1);

                    iteraciones.Add((i + 1, xr, error));

                    if (error < tolerancia)
                        break;

                    x0 = x1;
                    x1 = xr;
                }

                // Insertar un nuevo registro en la tabla Calculo y obtener el calculo_id
                int calculoId;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("INSERT INTO Calculo OUTPUT INSERTED.ID VALUES (DEFAULT)", connection))
                    {
                        calculoId = (int)command.ExecuteScalar();
                    }

                    foreach (var iter in iteraciones)
                    {
                        string query = "INSERT INTO MetodoSecante(calculo_id, iteracion, xr, error) VALUES (@calculo_id, @iteracion, @xr, @error)";
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

                // Limpiar el DataGridView antes de cargar los nuevos datos
                dataGridViewResultadoSecante.DataSource = null;
                dataGridViewResultadoSecante.Rows.Clear();
                dataGridViewResultadoSecante.Columns.Clear();

                CargarDatosDesdeSQL(calculoId);
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
                expression.Parameters["x"] = 1;
                var result = expression.Evaluate();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void CargarDatosDesdeSQL(int calculoId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT iteracion, xr, error FROM MetodoSecante WHERE calculo_id = @calculo_id";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@calculo_id", calculoId);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewResultadoSecante.DataSource = dataTable;
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

                    PdfPTable table = new PdfPTable(dataGridViewResultadoSecante.Columns.Count);

                    foreach (DataGridViewColumn column in dataGridViewResultadoSecante.Columns)
                    {
                        table.AddCell(new Phrase(column.HeaderText));
                    }

                    foreach (DataGridViewRow row in dataGridViewResultadoSecante.Rows)
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

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridViewResultadoSecante.DataSource = null;
            dataGridViewResultadoSecante.Rows.Clear();
            dataGridViewResultadoSecante.Columns.Clear();
            dataGridViewResultadoSecante.Refresh();
            txtFuncion.Clear();
            txtx0.Clear();
            txtTolerancia.Clear();
            txtMaxiter.Clear();
        }
    }
}
