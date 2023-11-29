namespace CMPT
{
    partial class AddMovieForm
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
            MovieIdText = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // MovieIdText
            // 
            MovieIdText.AutoSize = true;
            MovieIdText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MovieIdText.Location = new Point(177, 9);
            MovieIdText.Name = "MovieIdText";
            MovieIdText.Size = new Size(0, 25);
            MovieIdText.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Movie ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 4;
            label2.Text = "Movie Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 5;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 6;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 178);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 7;
            label5.Text = "Copies:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(141, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 33);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(141, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 33);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(141, 134);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(141, 175);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(54, 33);
            textBox4.TabIndex = 11;
            // 
            // AddMovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 222);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MovieIdText);
            Controls.Add(label1);
            Name = "AddMovieForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Movie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MovieIdText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}