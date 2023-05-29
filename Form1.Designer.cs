namespace kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelLogo = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.Calculator = new System.Windows.Forms.Button();
            this.CalculatorFullVersion = new System.Windows.Forms.Button();
            this.Solution_from_picture_and_text = new System.Windows.Forms.Button();
            this.Equation = new System.Windows.Forms.Button();
            this.Functions = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.textBox1);
            this.panelTitle.Location = new System.Drawing.Point(337, 12);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(683, 272);
            this.panelTitle.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(498, 22);
            this.textBox1.TabIndex = 60;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.Location = new System.Drawing.Point(12, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(322, 272);
            this.panelLogo.TabIndex = 8;
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.Calculator);
            this.panelMenu.Controls.Add(this.CalculatorFullVersion);
            this.panelMenu.Controls.Add(this.Solution_from_picture_and_text);
            this.panelMenu.Controls.Add(this.Equation);
            this.panelMenu.Controls.Add(this.Functions);
            this.panelMenu.Location = new System.Drawing.Point(29, 290);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(991, 327);
            this.panelMenu.TabIndex = 9;
            // 
            // Calculator
            // 
            this.Calculator.Location = new System.Drawing.Point(3, 3);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(1001, 41);
            this.Calculator.TabIndex = 1;
            this.Calculator.Text = "Calculator";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // CalculatorFullVersion
            // 
            this.CalculatorFullVersion.Location = new System.Drawing.Point(3, 50);
            this.CalculatorFullVersion.Name = "CalculatorFullVersion";
            this.CalculatorFullVersion.Size = new System.Drawing.Size(988, 46);
            this.CalculatorFullVersion.TabIndex = 2;
            this.CalculatorFullVersion.Text = "CalculatorFullVersion";
            this.CalculatorFullVersion.UseVisualStyleBackColor = true;
            this.CalculatorFullVersion.Click += new System.EventHandler(this.CalculatorFullVersion_Click);
            // 
            // Solution_from_picture_and_text
            // 
            this.Solution_from_picture_and_text.Location = new System.Drawing.Point(3, 102);
            this.Solution_from_picture_and_text.Name = "Solution_from_picture_and_text";
            this.Solution_from_picture_and_text.Size = new System.Drawing.Size(988, 46);
            this.Solution_from_picture_and_text.TabIndex = 3;
            this.Solution_from_picture_and_text.Text = "solution_from_picture_and_text";
            this.Solution_from_picture_and_text.UseVisualStyleBackColor = true;
            this.Solution_from_picture_and_text.Click += new System.EventHandler(this.Solution_from_picture_and_text_Click);
            // 
            // Equation
            // 
            this.Equation.Location = new System.Drawing.Point(3, 154);
            this.Equation.Name = "Equation";
            this.Equation.Size = new System.Drawing.Size(988, 46);
            this.Equation.TabIndex = 4;
            this.Equation.Text = "Equation";
            this.Equation.UseVisualStyleBackColor = true;
            this.Equation.Click += new System.EventHandler(this.Equation_Click);
            // 
            // Functions
            // 
            this.Functions.Location = new System.Drawing.Point(3, 206);
            this.Functions.Name = "Functions";
            this.Functions.Size = new System.Drawing.Size(988, 46);
            this.Functions.TabIndex = 5;
            this.Functions.Text = "Functions";
            this.Functions.UseVisualStyleBackColor = true;
            this.Functions.Click += new System.EventHandler(this.Functions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 629);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelLogo);
            this.Controls.Add(this.panelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelTitle;
        private System.Windows.Forms.FlowLayoutPanel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button CalculatorFullVersion;
        private System.Windows.Forms.Button Solution_from_picture_and_text;
        private System.Windows.Forms.Button Equation;
        private System.Windows.Forms.Button Functions;
        private System.Windows.Forms.TextBox textBox1;
    }
}

