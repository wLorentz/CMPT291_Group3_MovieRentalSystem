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
            MovieNameTextBox = new TextBox();
            GenreTextBox = new TextBox();
            PriceTextBox = new TextBox();
            CopiesTextBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // MovieIdText
            // 
            MovieIdText.AutoSize = true;
            MovieIdText.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MovieIdText.Location = new Point(141, 9);
            MovieIdText.Name = "MovieIdText";
            MovieIdText.Size = new Size(30, 25);
            MovieIdText.TabIndex = 3;
            MovieIdText.Text = "ID";
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
            // MovieNameTextBox
            // 
            MovieNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            MovieNameTextBox.Location = new Point(141, 57);
            MovieNameTextBox.Name = "MovieNameTextBox";
            MovieNameTextBox.Size = new Size(200, 33);
            MovieNameTextBox.TabIndex = 8;
            // 
            // GenreTextBox
            // 
            GenreTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            GenreTextBox.Location = new Point(141, 96);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(200, 33);
            GenreTextBox.TabIndex = 9;
            // 
            // PriceTextBox
            // 
            PriceTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            PriceTextBox.Location = new Point(141, 134);
            PriceTextBox.Name = "PriceTextBox";
            PriceTextBox.Size = new Size(100, 33);
            PriceTextBox.TabIndex = 10;
            // 
            // CopiesTextBox
            // 
            CopiesTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CopiesTextBox.Location = new Point(141, 175);
            CopiesTextBox.Name = "CopiesTextBox";
            CopiesTextBox.Size = new Size(54, 33);
            CopiesTextBox.TabIndex = 11;
            // 
            // saveButton
            // 
            saveButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location = new Point(12, 236);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 38);
            saveButton.TabIndex = 24;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // AddMovieForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 286);
            Controls.Add(saveButton);
            Controls.Add(CopiesTextBox);
            Controls.Add(PriceTextBox);
            Controls.Add(GenreTextBox);
            Controls.Add(MovieNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MovieIdText);
            Controls.Add(label1);
            Name = "AddMovieForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Movie";
            Load += AddMovieForm_Load;
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
        private TextBox MovieNameTextBox;
        private TextBox GenreTextBox;
        private TextBox PriceTextBox;
        private TextBox CopiesTextBox;
        private Button saveButton;
    }
}