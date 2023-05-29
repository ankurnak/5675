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
    public partial class FormSolution : Form
    {
        private double firstNumber;
        private double secondNumber;
        private char operation;
        public FormSolution()
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
        private List<string> savedCalculations = new List<string>();

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

        private void open_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files|*.txt";
                openFileDialog.Title = "Open Calculation File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string calculation = File.ReadAllText(openFileDialog.FileName);
                    CalculateAndDisplayResult(calculation);
                }
            }
        }
        private void CalculateAndDisplayResult(string calculation)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(calculation, "");

                textBox1.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while performing the calculation: " + ex.Message);
            }
        }
        private void open_picture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.gif;*.bmp";
                openFileDialog.Title = "Open Image File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;
                    DisplayImage(imagePath);
                }
            }
        }
        private void DisplayImage(string imagePath)
        {

            Image image = Image.FromFile(imagePath);


            pictureBox1.Image = image;
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

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
