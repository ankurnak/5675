using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            panelMenu.BackColor = Color.DarkGray;

            // Оформление panelLogo
            panelLogo.BackColor = Color.LightGray;
                                         
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;

            // Оформление panelTitle
            panelTitle.BackColor = Color.LightBlue;
            panelTitle.ForeColor = Color.White;
            textBox1.Font = new Font("Arial", 40, FontStyle.Bold);
            textBox1.Text = "Калькулятор";
        }

        private void Calculator_Click(object sender, EventArgs e)
        {
            FormCalculator formCalculator = new FormCalculator();
            formCalculator.Show();
            Calculator.BackColor = Color.LightBlue;
        }
        private void Calculator_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            Calculator.BackColor = Color.Transparent;
        }
        private void CalculatorFullVersion_Click(object sender, EventArgs e)
        {
            FormCalculatorFullVersion formCalculatorFullVersion = new FormCalculatorFullVersion();
            formCalculatorFullVersion.Show();
            CalculatorFullVersion.BackColor = Color.LightBlue;
        }
        private void CalculatorFullVersion_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            CalculatorFullVersion.BackColor = Color.Transparent;
        }
        private void Solution_from_picture_and_text_Click(object sender, EventArgs e)
        {
            FormSolution formSolution = new FormSolution();
            formSolution.Show();
            Solution_from_picture_and_text.BackColor = Color.LightBlue;
        }
        private void Solution_from_picture_and_text_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            Solution_from_picture_and_text.BackColor = Color.Transparent;
        }
        private void Equation_Click(object sender, EventArgs e)
        {
            FormEquation formEquation = new FormEquation();
            formEquation.Show();
            Equation.BackColor = Color.LightBlue;
        }
        private void Equation_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            Equation.BackColor = Color.Transparent;
        }
        private void Functions_Click(object sender, EventArgs e)
        {
            FormFunctions formFunctions = new FormFunctions();
            formFunctions.Show();
            Functions.BackColor = Color.LightBlue;
        }
        private void Functions_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            Functions.BackColor = Color.Transparent;
        }
       

       
    }
}
