using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class FormCalculatorFullVersion : Form
    {
        private double firstNumber;
        private double secondNumber;
        private char operation;
        public FormCalculatorFullVersion()
        {
            InitializeComponent();
            ApplyButtonStyles();
            ApplyTextBoxStyles();
        }
        private void ApplyButtonStyles()
        {
            var buttons = Controls.OfType<Button>();
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
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 12);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.TextAlign = HorizontalAlignment.Right;
        }
        private void Addition_Click(object sender, EventArgs e)
        {
            // получаем первое число, тип double, разделение по точке чтобы понимать где начинается дробаня часть  CultureInfo.InvariantCulture
            firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            operation = '+';
            // чистим строку ввода, для ввода второго числа
            textBox1.Text = "";
        }

        private void Substraction_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "-";
            }
            else
            {
                firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
                operation = '-';
                textBox1.Text = "";
            }
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            operation = '*';
            textBox1.Text = "";
        }

        private void division_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            operation = '/';
            textBox1.Text = "";
        }
        private List<string> savedCalculations = new List<string>();
        private void brackets_Click(object sender, EventArgs e)
        {
            int openBracketsCount = textBox1.Text.Count(c => c == '(');
            int closedBracketsCount = textBox1.Text.Count(c => c == ')');

            if (openBracketsCount > closedBracketsCount)
            {
                textBox1.Text += ")";
            }
            else
            {
                textBox1.Text += "(";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void point_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void equality_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBox1.Text, CultureInfo.InvariantCulture);
            double result;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    textBox1.Text = result.ToString();
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    textBox1.Text = result.ToString();
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    textBox1.Text = result.ToString();
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Cannot divide by zero");
                        textBox1.Text = "";
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                        textBox1.Text = result.ToString();
                    }
                    break;
                case '%':
                    result = firstNumber * (secondNumber / 100);
                    break;
                default:
                    break;
            }
        }

        private void Clean_all_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, (textBox1.Text.Length - 1));
            }
        }

        private void percent_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(textBox1.Text);
            operation = '%';
        }

        private void sin_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double radians = angle * Math.PI / 180;
            double result = Math.Sin(radians);
            textBox1.Text = result.ToString();
        }

        private void cos_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double radians = angle * Math.PI / 180;
            double result = Math.Cos(radians);
            textBox1.Text = result.ToString();
        }

        private void tg_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double radians = angle * Math.PI / 180;
            double result = Math.Tan(radians);
            textBox1.Text = result.ToString();
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double radians = angle * Math.PI / 180;
            double result = 1 / Math.Tan(radians);
            textBox1.Text = result.ToString();
        }

        private void save_as_picture_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.Title = "Save Result as Image";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Bitmap bitmap = new Bitmap(textBox1.Width, textBox1.Height))
                    {
                        textBox1.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                        bitmap.Save(saveFileDialog.FileName);
                        MessageBox.Show("Result saved as image.");
                    }
                }
            }
        }

        private void save_as_text_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text File|*.txt";
                    saveFileDialog.Title = "Save Result as Text";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string result = textBox1.Text;
                        File.WriteAllText(saveFileDialog.FileName, result);
                        MessageBox.Show("Result saved as text.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No result to save.");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                savedCalculations.Add(textBox1.Text);
                MessageBox.Show("Приклад збережено!");
            }
            else
            {
                MessageBox.Show("Немає даних для збереження.");
            }
        }

        private void sqrt2_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Sqrt(number);
            textBox1.Text = result.ToString();
        }

        private void review_Click(object sender, EventArgs e)
        {
            if (savedCalculations.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string calc in savedCalculations)
                {
                    sb.AppendLine(calc);
                }
                MessageBox.Show(sb.ToString(), "Збережені приклади");
            }
            else
            {
                MessageBox.Show("Немає збережених прикладів.");
            }
        }

        private void abs_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Abs(number);
            textBox1.Text = result.ToString();
        }

        private void divide100_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = number / 100;
            textBox1.Text = result.ToString();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.PI * number;
            textBox1.Text = result.ToString();
        }

        private void rad_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double result = angle * 180 / Math.PI;
            textBox1.Text = result.ToString();
        }

        private void pow3_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Pow(number, 3);
            textBox1.Text = result.ToString();
        }

        private void ln_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Log10(number);
            textBox1.Text = result.ToString();
        }

        private void lg_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Log(number);
            textBox1.Text = result.ToString();
        }

        private void sqrt3_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Pow(number, 1.0 / 3.0);
            textBox1.Text = result.ToString();
        }

        private void pow2_Click(object sender, EventArgs e)
        {
            double number = double.Parse(textBox1.Text);
            double result = Math.Pow(number, 2);
            textBox1.Text = result.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
