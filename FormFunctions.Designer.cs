namespace kalkulator
{
    partial class FormFunctions
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.xText = new System.Windows.Forms.TextBox();
            this.resultText = new System.Windows.Forms.TextBox();
            this.function = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // xText
            // 
            this.xText.Location = new System.Drawing.Point(166, 186);
            this.xText.Name = "xText";
            this.xText.Size = new System.Drawing.Size(100, 22);
            this.xText.TabIndex = 0;
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(357, 186);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(100, 22);
            this.resultText.TabIndex = 1;
            // 
            // function
            // 
            this.function.Location = new System.Drawing.Point(166, 246);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(291, 23);
            this.function.TabIndex = 2;
            this.function.Text = "функція";
            this.function.UseVisualStyleBackColor = true;
            this.function.Click += new System.EventHandler(this.function_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(553, 118);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 63);
            this.panel1.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(887, 63);
            this.panel2.TabIndex = 107;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(267, 302);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 29);
            this.cancel.TabIndex = 146;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FormFunctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 574);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.function);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.xText);
            this.Name = "FormFunctions";
            this.Text = "FormFunctions";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xText;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button function;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancel;
    }
}