using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace kalkulator
{
    public partial class FormEquation : Form
    {
      

        public FormEquation()
        {
            InitializeComponent();
            ApplyButtonStyles();
            ApplyTextBoxStyles();
        }
        private void ApplyButtonStyles()
        {
            var buttons = Controls.OfType<System.Windows.Forms.Button>();
            foreach (var button in buttons)
            {
                button.BackColor = Color.LightGray;
                button.ForeColor = Color.Black;
                button.Font = new Font(button.Font.FontFamily, 12);
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.Blue;
                button.FlatAppearance.BorderSize = 1;
            }
        }

        // Применить стили к текстовому полю
        private void ApplyTextBoxStyles()
        {
             solve.BackColor = Color.White;
            solve.ForeColor = Color.Black;
            solve.Font = new Font(solve.Font.FontFamily, 12);
            solve.BorderStyle = BorderStyle.FixedSingle;
            solve.TextAlign = HorizontalAlignment.Right;

            aTextBox.BackColor = Color.White;
            aTextBox.ForeColor = Color.Black;
            aTextBox.Font = new Font(aTextBox.Font.FontFamily, 12);
            aTextBox.BorderStyle = BorderStyle.FixedSingle;
            aTextBox.TextAlign = HorizontalAlignment.Right;

            bTextBox.BackColor = Color.White;
            bTextBox.ForeColor = Color.Black;
            bTextBox.Font = new Font(bTextBox.Font.FontFamily, 12);
            bTextBox.BorderStyle = BorderStyle.FixedSingle;
            bTextBox.TextAlign = HorizontalAlignment.Right;

            cTextBox.BackColor = Color.White;
            cTextBox.ForeColor = Color.Black;
            cTextBox.Font = new Font(cTextBox.Font.FontFamily, 12);
            cTextBox.BorderStyle = BorderStyle.FixedSingle;
            cTextBox.TextAlign = HorizontalAlignment.Right;

            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 12);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }
        private void square_Click(object sender, EventArgs e)
        {
            double a = double.Parse(aTextBox.Text);
            double b = double.Parse(bTextBox.Text);
            double c = double.Parse(cTextBox.Text);

            // Вычисление уравнения
            double discriminant = Math.Pow(b, 2) - 4 * a * c;

            // Проверка дискриминанта
            if (discriminant < 0)
            {
                solve.Text = "Уравнение не имеет действительных корней";
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                solve.Text = "Уравнение имеет один корень: x = " + x;
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                solve.Text = "Уравнение имеет два корня: x1 = " + x1 + ", x2 = " + x2;
            }
           
        }
        private double SolveEquation(string equation)
        {
            DataTable table = new DataTable();
            DataColumn column = new DataColumn("Expression", typeof(double), equation);
            table.Columns.Add(column);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return (double)row["Expression"];
        }

        private void usual_Click(object sender, EventArgs e)
        {
            string equation = textBox1.Text;

            try
            {
                double result = SolveEquation(equation);
                solve.Text = "Результат: " + result;
            }
            catch (Exception ex)
            {
                solve.Text = "Ошибка: " + ex.Message;
            }
        }

        private void graphbutton_Click(object sender, EventArgs e)
        {
            string equation = solve.Text;

            // Generate and display the graph
            DisplayGraph(equation);
        }
        private void DisplayGraph(string equation)
        {
            // Clear the previous graph
            chart1.Series.Clear();

            // Create a new series for the graph
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;

            // Generate points for the graph
            for (double x = -10; x <= 10; x += 0.1)
            {
                try
                {
                    // Replace the 'x' variable in the equation with the current x value
                    string equationWithX = equation.Replace("x", x.ToString(CultureInfo.InvariantCulture));

                    // Evaluate the equation using a math expression parser or library
                    var result = new DataTable().Compute(equationWithX, null);
                    double y = Convert.ToDouble(result);

                    // Add the point to the series
                    series.Points.AddXY(x, y);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during equation evaluation
                    MessageBox.Show("Error evaluating the equation: " + ex.Message);
                    return;
                }
            }

            // Add the series to the chart
            chart1.Series.Add(series);

            // Set the chart title and axis labels
            chart1.Titles.Clear();
            chart1.Titles.Add("Graph");
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.ChartAreas[0].AxisY.Title = "Y";

            // Show the chart
            chart1.Visible = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
