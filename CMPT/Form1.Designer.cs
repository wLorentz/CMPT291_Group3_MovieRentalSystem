namespace CMPT
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            movies = new DataGridView();
            readDBButton = new Button();
            Movie = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)movies).BeginInit();
            SuspendLayout();
            // 
            // movies
            // 
            movies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            movies.Columns.AddRange(new DataGridViewColumn[] { Movie });
            movies.Location = new Point(25, 20);
            movies.Name = "movies";
            movies.RowTemplate.Height = 25;
            movies.Size = new Size(763, 181);
            movies.TabIndex = 0;
            // 
            // readDBButton
            // 
            readDBButton.Location = new Point(312, 313);
            readDBButton.Name = "readDBButton";
            readDBButton.Size = new Size(163, 23);
            readDBButton.TabIndex = 1;
            readDBButton.Text = "Read Database";
            readDBButton.UseVisualStyleBackColor = true;
            readDBButton.Click += button1_Click;
            // 
            // Movie
            // 
            Movie.HeaderText = "Movie Title";
            Movie.Name = "Movie";
            Movie.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(readDBButton);
            Controls.Add(movies);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)movies).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView movies;
        private Button readDBButton;
        private DataGridViewTextBoxColumn Movie;
    }
}