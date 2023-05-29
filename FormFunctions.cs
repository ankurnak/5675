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
using System.Windows.Forms.DataVisualization.Charting;

namespace kalkulator
{
    public partial class FormFunctions : Form
    {
        public FormFunctions()
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

    
        private void ApplyTextBoxStyles()
        {
            xText.BackColor = Color.White;
            xText.ForeColor = Color.Black;
            xText.Font = new Font(xText.Font.FontFamily, 12);
            xText.BorderStyle = BorderStyle.FixedSingle;
            xText.TextAlign = HorizontalAlignment.Right;

            resultText.BackColor = Color.White;
            resultText.ForeColor = Color.Black;
            resultText.Font = new Font(resultText.Font.FontFamily, 12);
            resultText.BorderStyle = BorderStyle.FixedSingle;
            resultText.TextAlign = HorizontalAlignment.Right;
        }
        private void function_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(xText.Text);
                double result = CalculateF(x);
                resultText.Text = $"Значение F({x}) = {result}";

                // Очистка графика
                chart1.Series.Clear();

                // Добавление точки на график
                Series series = chart1.Series.Add("Function");
                series.Points.AddXY(x, result);

                // Настройка внешнего вида графика
                chart1.ChartAreas[0].AxisX.Title = "X";
                chart1.ChartAreas[0].AxisY.Title = "Y";
                chart1.ChartAreas[0].RecalculateAxesScale();
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
            catch (FormatException)
            {
                resultText.Text = "Ошибка: Некорректный формат ввода";
                chart1.Series.Clear();
            }
        }
        private double CalculateF(double x)
        {
            // Здесь можно определить свою функцию F(x)
            double result = Math.Sin(x) + Math.Cos(x);
            return result;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
