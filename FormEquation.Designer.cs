namespace kalkulator
{
    partial class FormEquation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.square = new System.Windows.Forms.Button();
            this.usual = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.aTextBox = new System.Windows.Forms.TextBox();
            this.bTextBox = new System.Windows.Forms.TextBox();
            this.cTextBox = new System.Windows.Forms.TextBox();
            this.graphbutton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // square
            // 
            this.square.Location = new System.Drawing.Point(122, 353);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(111, 46);
            this.square.TabIndex = 0;
            this.square.Text = "квалратне рівняння";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.square_Click);
            // 
            // usual
            // 
            this.usual.Location = new System.Drawing.Point(346, 353);
            this.usual.Name = "usual";
            this.usual.Size = new System.Drawing.Size(111, 46);
            this.usual.TabIndex = 1;
            this.usual.Text = "звичайне рівняння";
            this.usual.UseVisualStyleBackColor = true;
            this.usual.Click += new System.EventHandler(this.usual_Click);
            // 
            // solve
            // 
            this.solve.Location = new System.Drawing.Point(122, 263);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(335, 22);
            this.solve.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(685, 99);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart";
            // 
            // aTextBox
            // 
            this.aTextBox.Location = new System.Drawing.Point(122, 124);
            this.aTextBox.Name = "aTextBox";
            this.aTextBox.Size = new System.Drawing.Size(111, 22);
            this.aTextBox.TabIndex = 5;
            // 
            // bTextBox
            // 
            this.bTextBox.Location = new System.Drawing.Point(122, 164);
            this.bTextBox.Name = "bTextBox";
            this.bTextBox.Size = new System.Drawing.Size(111, 22);
            this.bTextBox.TabIndex = 6;
            // 
            // cTextBox
            // 
            this.cTextBox.Location = new System.Drawing.Point(122, 203);
            this.cTextBox.Name = "cTextBox";
            this.cTextBox.Size = new System.Drawing.Size(111, 22);
            this.cTextBox.TabIndex = 7;
            // 
            // graphbutton
            // 
            this.graphbutton.Location = new System.Drawing.Point(346, 445);
            this.graphbutton.Name = "graphbutton";
            this.graphbutton.Size = new System.Drawing.Size(94, 29);
            this.graphbutton.TabIndex = 141;
            this.graphbutton.Text = "graphbutton";
            this.graphbutton.UseVisualStyleBackColor = true;
            this.graphbutton.Click += new System.EventHandler(this.graphbutton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(346, 164);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 22);
            this.textBox1.TabIndex = 142;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 63);
            this.panel1.TabIndex = 143;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(2, 611);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 63);
            this.panel2.TabIndex = 144;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(122, 445);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 29);
            this.cancel.TabIndex = 145;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FormEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 675);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.graphbutton);
            this.Controls.Add(this.cTextBox);
            this.Controls.Add(this.bTextBox);
            this.Controls.Add(this.aTextBox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.solve);
            this.Controls.Add(this.usual);
            this.Controls.Add(this.square);
            this.Name = "FormEquation";
            this.Text = "FormEquation";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button usual;
        private System.Windows.Forms.TextBox solve;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox aTextBox;
        private System.Windows.Forms.TextBox bTextBox;
        private System.Windows.Forms.TextBox cTextBox;
        private System.Windows.Forms.Button graphbutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancel;
    }
}