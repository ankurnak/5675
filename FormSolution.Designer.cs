namespace kalkulator
{
    partial class FormSolution
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save_as_text = new System.Windows.Forms.Button();
            this.Clean_all = new System.Windows.Forms.Button();
            this.equality = new System.Windows.Forms.Button();
            this.save_as_picture = new System.Windows.Forms.Button();
            this.review = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.open_picture = new System.Windows.Forms.Button();
            this.open_file = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(212, 270);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 200);
            this.pictureBox1.TabIndex = 97;
            this.pictureBox1.TabStop = false;
            // 
            // save_as_text
            // 
            this.save_as_text.Location = new System.Drawing.Point(892, 173);
            this.save_as_text.Name = "save_as_text";
            this.save_as_text.Size = new System.Drawing.Size(94, 29);
            this.save_as_text.TabIndex = 96;
            this.save_as_text.Text = "зберегти як картинку";
            this.save_as_text.UseVisualStyleBackColor = true;
            this.save_as_text.Click += new System.EventHandler(this.save_as_text_Click);
            // 
            // Clean_all
            // 
            this.Clean_all.Location = new System.Drawing.Point(766, 173);
            this.Clean_all.Name = "Clean_all";
            this.Clean_all.Size = new System.Drawing.Size(94, 29);
            this.Clean_all.TabIndex = 95;
            this.Clean_all.Text = "C";
            this.Clean_all.UseVisualStyleBackColor = true;
            this.Clean_all.Click += new System.EventHandler(this.Clean_all_Click);
            // 
            // equality
            // 
            this.equality.Location = new System.Drawing.Point(640, 173);
            this.equality.Name = "equality";
            this.equality.Size = new System.Drawing.Size(94, 29);
            this.equality.TabIndex = 94;
            this.equality.Text = "=";
            this.equality.UseVisualStyleBackColor = true;
            this.equality.Click += new System.EventHandler(this.equality_Click);
            // 
            // save_as_picture
            // 
            this.save_as_picture.Location = new System.Drawing.Point(510, 173);
            this.save_as_picture.Name = "save_as_picture";
            this.save_as_picture.Size = new System.Drawing.Size(94, 29);
            this.save_as_picture.TabIndex = 93;
            this.save_as_picture.Text = "зберегти як картинку";
            this.save_as_picture.UseVisualStyleBackColor = true;
            this.save_as_picture.Click += new System.EventHandler(this.save_as_picture_Click);
            // 
            // review
            // 
            this.review.Location = new System.Drawing.Point(141, 173);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(94, 29);
            this.review.TabIndex = 92;
            this.review.Text = "переглянути збережене";
            this.review.UseVisualStyleBackColor = true;
            this.review.Click += new System.EventHandler(this.review_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(23, 173);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(94, 29);
            this.save.TabIndex = 91;
            this.save.Text = "зберегти";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // open_picture
            // 
            this.open_picture.Location = new System.Drawing.Point(390, 173);
            this.open_picture.Name = "open_picture";
            this.open_picture.Size = new System.Drawing.Size(94, 29);
            this.open_picture.TabIndex = 90;
            this.open_picture.Text = "відкрити картинку";
            this.open_picture.UseVisualStyleBackColor = true;
            this.open_picture.Click += new System.EventHandler(this.open_picture_Click);
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(264, 173);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(94, 29);
            this.open_file.TabIndex = 89;
            this.open_file.Text = "відкрити файл";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(351, 22);
            this.textBox1.TabIndex = 88;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 63);
            this.panel1.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(1, 508);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 63);
            this.panel2.TabIndex = 107;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(390, 235);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(94, 29);
            this.cancel.TabIndex = 147;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // FormSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 572);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save_as_text);
            this.Controls.Add(this.Clean_all);
            this.Controls.Add(this.equality);
            this.Controls.Add(this.save_as_picture);
            this.Controls.Add(this.review);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open_picture);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.textBox1);
            this.Name = "FormSolution";
            this.Text = "FormSolution";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button save_as_text;
        private System.Windows.Forms.Button Clean_all;
        private System.Windows.Forms.Button equality;
        private System.Windows.Forms.Button save_as_picture;
        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button open_picture;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancel;
    }
}