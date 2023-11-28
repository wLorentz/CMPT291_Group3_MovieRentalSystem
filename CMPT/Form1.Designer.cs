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
            movieIDs = new DataGridViewTextBoxColumn();
            movieTitles = new DataGridViewTextBoxColumn();
            movieGenres = new DataGridViewTextBoxColumn();
            moviePrices = new DataGridViewTextBoxColumn();
            movieCopies = new DataGridViewTextBoxColumn();
            movieRatings = new DataGridViewTextBoxColumn();
            first_tab = new TabControl();
            rentals = new TabPage();
            button1 = new Button();
            dueDatePicker = new DateTimePicker();
            label4 = new Label();
            retalDatePicker = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            movieDropdown = new ComboBox();
            editCustomerButton = new Button();
            addCustomerButton = new Button();
            label1 = new Label();
            customerDropdown = new ComboBox();
            allMovies = new TabPage();
            movieDeletebutton = new Button();
            updateMoviesbutton = new Button();
            searchMoviebutton = new Button();
            searchMoviebox = new TextBox();
            runReports = new TabPage();
            runReport = new Button();
            reports = new ListBox();
            reportOutputText = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)movies).BeginInit();
            first_tab.SuspendLayout();
            rentals.SuspendLayout();
            allMovies.SuspendLayout();
            runReports.SuspendLayout();
            SuspendLayout();
            // 
            // movies
            // 
            movies.AllowUserToAddRows = false;
            movies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            movies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            movies.Columns.AddRange(new DataGridViewColumn[] { movieIDs, movieTitles, movieGenres, moviePrices, movieCopies, movieRatings });
            movies.Location = new Point(0, 0);
            movies.Name = "movies";
            movies.RowHeadersWidth = 51;
            movies.RowTemplate.Height = 25;
            movies.Size = new Size(1143, 296);
            movies.TabIndex = 2;
            // 
            // movieIDs
            // 
            movieIDs.HeaderText = "Movie ID";
            movieIDs.MinimumWidth = 6;
            movieIDs.Name = "movieIDs";
            // 
            // movieTitles
            // 
            movieTitles.HeaderText = "Movie Title";
            movieTitles.MinimumWidth = 6;
            movieTitles.Name = "movieTitles";
            // 
            // movieGenres
            // 
            movieGenres.HeaderText = "Genre";
            movieGenres.MinimumWidth = 6;
            movieGenres.Name = "movieGenres";
            // 
            // moviePrices
            // 
            moviePrices.HeaderText = "Price";
            moviePrices.MinimumWidth = 6;
            moviePrices.Name = "moviePrices";
            // 
            // movieCopies
            // 
            movieCopies.HeaderText = "Copies";
            movieCopies.MinimumWidth = 6;
            movieCopies.Name = "movieCopies";
            // 
            // movieRatings
            // 
            movieRatings.HeaderText = "Rating";
            movieRatings.MinimumWidth = 6;
            movieRatings.Name = "movieRatings";
            // 
            // first_tab
            // 
            first_tab.Controls.Add(rentals);
            first_tab.Controls.Add(allMovies);
            first_tab.Controls.Add(runReports);
            first_tab.Location = new Point(0, 0);
            first_tab.Margin = new Padding(3, 2, 3, 2);
            first_tab.Name = "first_tab";
            first_tab.SelectedIndex = 0;
            first_tab.Size = new Size(1159, 397);
            first_tab.TabIndex = 3;
            // 
            // rentals
            // 
            rentals.Controls.Add(button1);
            rentals.Controls.Add(dueDatePicker);
            rentals.Controls.Add(label4);
            rentals.Controls.Add(retalDatePicker);
            rentals.Controls.Add(label3);
            rentals.Controls.Add(label2);
            rentals.Controls.Add(movieDropdown);
            rentals.Controls.Add(editCustomerButton);
            rentals.Controls.Add(addCustomerButton);
            rentals.Controls.Add(label1);
            rentals.Controls.Add(customerDropdown);
            rentals.Location = new Point(4, 24);
            rentals.Name = "rentals";
            rentals.Size = new Size(1151, 369);
            rentals.TabIndex = 1;
            rentals.Text = "Rentals";
            rentals.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(8, 276);
            button1.Name = "button1";
            button1.Size = new Size(116, 62);
            button1.TabIndex = 10;
            button1.Text = "Create Rental";
            button1.UseVisualStyleBackColor = true;
            // 
            // dueDatePicker
            // 
            dueDatePicker.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dueDatePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dueDatePicker.Location = new Point(130, 182);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(200, 33);
            dueDatePicker.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 188);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 8;
            label4.Text = "Due Date";
            // 
            // retalDatePicker
            // 
            retalDatePicker.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            retalDatePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            retalDatePicker.Location = new Point(130, 124);
            retalDatePicker.Name = "retalDatePicker";
            retalDatePicker.Size = new Size(200, 33);
            retalDatePicker.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(8, 130);
            label3.Name = "label3";
            label3.Size = new Size(108, 25);
            label3.TabIndex = 6;
            label3.Text = "Rental Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 73);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 5;
            label2.Text = "Movie";
            // 
            // movieDropdown
            // 
            movieDropdown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            movieDropdown.FormattingEnabled = true;
            movieDropdown.Location = new Point(130, 70);
            movieDropdown.Name = "movieDropdown";
            movieDropdown.Size = new Size(225, 33);
            movieDropdown.TabIndex = 4;
            // 
            // editCustomerButton
            // 
            editCustomerButton.Location = new Point(410, 18);
            editCustomerButton.Name = "editCustomerButton";
            editCustomerButton.Size = new Size(43, 25);
            editCustomerButton.TabIndex = 3;
            editCustomerButton.Text = "Edit";
            editCustomerButton.UseVisualStyleBackColor = true;
            editCustomerButton.Visible = false;
            editCustomerButton.Click += editCustomerButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(361, 18);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(43, 25);
            addCustomerButton.TabIndex = 2;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            // 
            // customerDropdown
            // 
            customerDropdown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customerDropdown.FormattingEnabled = true;
            customerDropdown.Items.AddRange(new object[] { "Customer1" });
            customerDropdown.Location = new Point(130, 15);
            customerDropdown.Name = "customerDropdown";
            customerDropdown.Size = new Size(225, 33);
            customerDropdown.TabIndex = 0;
            customerDropdown.SelectedIndexChanged += customerDropdown_SelectedIndexChanged;
            customerDropdown.KeyUp += customerDropdown_KeyUp;
            // 
            // allMovies
            // 
            allMovies.Controls.Add(movieDeletebutton);
            allMovies.Controls.Add(updateMoviesbutton);
            allMovies.Controls.Add(searchMoviebutton);
            allMovies.Controls.Add(searchMoviebox);
            allMovies.Controls.Add(movies);
            allMovies.Location = new Point(4, 24);
            allMovies.Margin = new Padding(3, 2, 3, 2);
            allMovies.Name = "allMovies";
            allMovies.Padding = new Padding(3, 2, 3, 2);
            allMovies.Size = new Size(1151, 369);
            allMovies.TabIndex = 0;
            allMovies.Text = "Movies";
            allMovies.UseVisualStyleBackColor = true;
            // 
            // movieDeletebutton
            // 
            movieDeletebutton.Location = new Point(771, 304);
            movieDeletebutton.Margin = new Padding(3, 2, 3, 2);
            movieDeletebutton.Name = "movieDeletebutton";
            movieDeletebutton.Size = new Size(82, 22);
            movieDeletebutton.TabIndex = 6;
            movieDeletebutton.Text = "Delete";
            movieDeletebutton.UseVisualStyleBackColor = true;
            movieDeletebutton.Click += movieDeletebutton_Click;
            // 
            // updateMoviesbutton
            // 
            updateMoviesbutton.Location = new Point(858, 304);
            updateMoviesbutton.Margin = new Padding(3, 2, 3, 2);
            updateMoviesbutton.Name = "updateMoviesbutton";
            updateMoviesbutton.Size = new Size(82, 22);
            updateMoviesbutton.TabIndex = 5;
            updateMoviesbutton.Text = "Update";
            updateMoviesbutton.UseVisualStyleBackColor = true;
            updateMoviesbutton.Click += updateMoviesbutton_Click;
            // 
            // searchMoviebutton
            // 
            searchMoviebutton.Location = new Point(946, 303);
            searchMoviebutton.Margin = new Padding(3, 2, 3, 2);
            searchMoviebutton.Name = "searchMoviebutton";
            searchMoviebutton.Size = new Size(82, 22);
            searchMoviebutton.TabIndex = 4;
            searchMoviebutton.Text = "Search";
            searchMoviebutton.UseVisualStyleBackColor = true;
            searchMoviebutton.Click += searchMoviebutton_Click;
            // 
            // searchMoviebox
            // 
            searchMoviebox.Location = new Point(1033, 303);
            searchMoviebox.Margin = new Padding(3, 2, 3, 2);
            searchMoviebox.Name = "searchMoviebox";
            searchMoviebox.Size = new Size(110, 23);
            searchMoviebox.TabIndex = 3;
            // 
            // runReports
            // 
            runReports.Controls.Add(runReport);
            runReports.Controls.Add(reports);
            runReports.Controls.Add(reportOutputText);
            runReports.Location = new Point(4, 24);
            runReports.Name = "runReports";
            runReports.Size = new Size(1151, 369);
            runReports.TabIndex = 2;
            runReports.Text = "Reports";
            runReports.UseVisualStyleBackColor = true;
            // 
            // runReport
            // 
            runReport.Location = new Point(927, 267);
            runReport.Name = "runReport";
            runReport.Size = new Size(75, 23);
            runReport.TabIndex = 2;
            runReport.Text = "Run Report";
            runReport.UseVisualStyleBackColor = true;
            runReport.Click += runReport_Click;
            // 
            // reports
            // 
            reports.FormattingEnabled = true;
            reports.ItemHeight = 15;
            reports.Items.AddRange(new object[] { "Report 1", "Report 2", "Report 3", "Report 4", "Report 5" });
            reports.Location = new Point(888, 31);
            reports.Name = "reports";
            reports.Size = new Size(114, 169);
            reports.TabIndex = 1;
            // 
            // reportOutputText
            // 
            reportOutputText.Location = new Point(3, 3);
            reportOutputText.Name = "reportOutputText";
            reportOutputText.Size = new Size(837, 315);
            reportOutputText.TabIndex = 0;
            reportOutputText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 404);
            Controls.Add(first_tab);
            Name = "Form1";
            Text = "Form1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)movies).EndInit();
            first_tab.ResumeLayout(false);
            rentals.ResumeLayout(false);
            rentals.PerformLayout();
            allMovies.ResumeLayout(false);
            allMovies.PerformLayout();
            runReports.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView movies;

        private TabControl first_tab;
        private TabPage allMovies;
        private Button searchMoviebutton;
        private TextBox searchMoviebox;
        private Button updateMoviesbutton;
        private DataGridViewTextBoxColumn movieIDs;
        private DataGridViewTextBoxColumn movieTitles;
        private DataGridViewTextBoxColumn movieGenres;
        private DataGridViewTextBoxColumn moviePrices;
        private DataGridViewTextBoxColumn movieCopies;
        private DataGridViewTextBoxColumn movieRatings;
        private Button movieDeletebutton;
        private TabPage rentals;
        private TabPage runReports;
        private RichTextBox reportOutputText;
        private ListBox reports;
        private Button runReport;
        private Label label2;
        private ComboBox movieDropdown;
        private Button editCustomerButton;
        private Button addCustomerButton;
        private Label label1;
        private ComboBox customerDropdown;
        private DateTimePicker dueDatePicker;
        private Label label4;
        private DateTimePicker retalDatePicker;
        private Label label3;
        private Button button1;
    }
}