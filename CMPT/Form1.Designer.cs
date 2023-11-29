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
            assignActorbox = new TextBox();
            assignActorbutton = new Button();
            addMoviebox = new TextBox();
            addMoviebutton = new Button();
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
            movies.Margin = new Padding(3, 4, 3, 4);
            movies.Name = "movies";
            movies.RowHeadersWidth = 51;
            movies.RowTemplate.Height = 25;
            movies.Size = new Size(1306, 395);
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
            first_tab.Name = "first_tab";
            first_tab.SelectedIndex = 0;
            first_tab.Size = new Size(1325, 529);
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
            rentals.Location = new Point(4, 29);
            rentals.Margin = new Padding(3, 4, 3, 4);
            rentals.Name = "rentals";
            rentals.Size = new Size(1317, 496);
            rentals.TabIndex = 1;
            rentals.Text = "Rentals";
            rentals.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(9, 368);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(133, 83);
            button1.TabIndex = 10;
            button1.Text = "Create Rental";
            button1.UseVisualStyleBackColor = true;
            // 
            // dueDatePicker
            // 
            dueDatePicker.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dueDatePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dueDatePicker.Location = new Point(149, 243);
            dueDatePicker.Margin = new Padding(3, 4, 3, 4);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(228, 39);
            dueDatePicker.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 251);
            label4.Name = "label4";
            label4.Size = new Size(115, 32);
            label4.TabIndex = 8;
            label4.Text = "Due Date";
            // 
            // retalDatePicker
            // 
            retalDatePicker.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            retalDatePicker.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            retalDatePicker.Location = new Point(149, 165);
            retalDatePicker.Margin = new Padding(3, 4, 3, 4);
            retalDatePicker.Name = "retalDatePicker";
            retalDatePicker.Size = new Size(228, 39);
            retalDatePicker.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(9, 173);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 6;
            label3.Text = "Rental Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(9, 97);
            label2.Name = "label2";
            label2.Size = new Size(81, 32);
            label2.TabIndex = 5;
            label2.Text = "Movie";
            // 
            // movieDropdown
            // 
            movieDropdown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            movieDropdown.FormattingEnabled = true;
            movieDropdown.Location = new Point(149, 93);
            movieDropdown.Margin = new Padding(3, 4, 3, 4);
            movieDropdown.Name = "movieDropdown";
            movieDropdown.Size = new Size(257, 40);
            movieDropdown.TabIndex = 4;
            // 
            // editCustomerButton
            // 
            editCustomerButton.Location = new Point(469, 24);
            editCustomerButton.Margin = new Padding(3, 4, 3, 4);
            editCustomerButton.Name = "editCustomerButton";
            editCustomerButton.Size = new Size(49, 33);
            editCustomerButton.TabIndex = 3;
            editCustomerButton.Text = "Edit";
            editCustomerButton.UseVisualStyleBackColor = true;
            editCustomerButton.Visible = false;
            editCustomerButton.Click += editCustomerButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(413, 24);
            addCustomerButton.Margin = new Padding(3, 4, 3, 4);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(49, 33);
            addCustomerButton.TabIndex = 2;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 24);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 1;
            label1.Text = "Customer ID";
            // 
            // customerDropdown
            // 
            customerDropdown.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            customerDropdown.FormattingEnabled = true;
            customerDropdown.Items.AddRange(new object[] { "Customer1" });
            customerDropdown.Location = new Point(149, 20);
            customerDropdown.Margin = new Padding(3, 4, 3, 4);
            customerDropdown.Name = "customerDropdown";
            customerDropdown.Size = new Size(257, 40);
            customerDropdown.TabIndex = 0;
            customerDropdown.SelectedIndexChanged += customerDropdown_SelectedIndexChanged;
            customerDropdown.KeyUp += customerDropdown_KeyUp;
            // 
            // allMovies
            // 
            allMovies.Controls.Add(assignActorbox);
            allMovies.Controls.Add(assignActorbutton);
            allMovies.Controls.Add(addMoviebox);
            allMovies.Controls.Add(addMoviebutton);
            allMovies.Controls.Add(movieDeletebutton);
            allMovies.Controls.Add(updateMoviesbutton);
            allMovies.Controls.Add(searchMoviebutton);
            allMovies.Controls.Add(searchMoviebox);
            allMovies.Controls.Add(movies);
            allMovies.Location = new Point(4, 29);
            allMovies.Name = "allMovies";
            allMovies.Padding = new Padding(3);
            allMovies.Size = new Size(1317, 496);
            allMovies.TabIndex = 0;
            allMovies.Text = "Movies";
            allMovies.UseVisualStyleBackColor = true;
            // 
            // assignActorbox
            // 
            assignActorbox.Location = new Point(369, 401);
            assignActorbox.Name = "assignActorbox";
            assignActorbox.Size = new Size(125, 27);
            assignActorbox.TabIndex = 10;
            assignActorbox.Text = "Enter Actor ID";
            assignActorbox.Click += assignActorbox_Click;
            // 
            // assignActorbutton
            // 
            assignActorbutton.Location = new Point(237, 402);
            assignActorbutton.Name = "assignActorbutton";
            assignActorbutton.Size = new Size(127, 29);
            assignActorbutton.TabIndex = 9;
            assignActorbutton.Text = "Assign Actor:";
            assignActorbutton.UseVisualStyleBackColor = true;
            assignActorbutton.Click += assignActorbutton_Click;
            // 
            // addMoviebox
            // 
            addMoviebox.Location = new Point(106, 404);
            addMoviebox.Name = "addMoviebox";
            addMoviebox.Size = new Size(125, 27);
            addMoviebox.TabIndex = 8;
            addMoviebox.Text = "Enter Movie ID";
            addMoviebox.Click += addMoviebox_Click;
            // 
            // addMoviebutton
            // 
            addMoviebutton.Location = new Point(6, 405);
            addMoviebutton.Name = "addMoviebutton";
            addMoviebutton.Size = new Size(94, 29);
            addMoviebutton.TabIndex = 7;
            addMoviebutton.Text = "Add Movie:";
            addMoviebutton.UseVisualStyleBackColor = true;
            addMoviebutton.Click += addMoviebutton_Click;
            // 
            // movieDeletebutton
            // 
            movieDeletebutton.Location = new Point(881, 405);
            movieDeletebutton.Name = "movieDeletebutton";
            movieDeletebutton.Size = new Size(94, 29);
            movieDeletebutton.TabIndex = 6;
            movieDeletebutton.Text = "Delete";
            movieDeletebutton.UseVisualStyleBackColor = true;
            movieDeletebutton.Click += movieDeletebutton_Click;
            // 
            // updateMoviesbutton
            // 
            updateMoviesbutton.Location = new Point(981, 405);
            updateMoviesbutton.Name = "updateMoviesbutton";
            updateMoviesbutton.Size = new Size(94, 29);
            updateMoviesbutton.TabIndex = 5;
            updateMoviesbutton.Text = "Update";
            updateMoviesbutton.UseVisualStyleBackColor = true;
            updateMoviesbutton.Click += updateMoviesbutton_Click;
            // 
            // searchMoviebutton
            // 
            searchMoviebutton.Location = new Point(1081, 404);
            searchMoviebutton.Name = "searchMoviebutton";
            searchMoviebutton.Size = new Size(94, 29);
            searchMoviebutton.TabIndex = 4;
            searchMoviebutton.Text = "Search";
            searchMoviebutton.UseVisualStyleBackColor = true;
            searchMoviebutton.Click += searchMoviebutton_Click;
            // 
            // searchMoviebox
            // 
            searchMoviebox.Location = new Point(1181, 404);
            searchMoviebox.Name = "searchMoviebox";
            searchMoviebox.Size = new Size(125, 27);
            searchMoviebox.TabIndex = 3;
            // 
            // runReports
            // 
            runReports.Controls.Add(runReport);
            runReports.Controls.Add(reports);
            runReports.Controls.Add(reportOutputText);
            runReports.Location = new Point(4, 29);
            runReports.Margin = new Padding(3, 4, 3, 4);
            runReports.Name = "runReports";
            runReports.Size = new Size(1317, 496);
            runReports.TabIndex = 2;
            runReports.Text = "Reports";
            runReports.UseVisualStyleBackColor = true;
            // 
            // runReport
            // 
            runReport.Location = new Point(1059, 356);
            runReport.Margin = new Padding(3, 4, 3, 4);
            runReport.Name = "runReport";
            runReport.Size = new Size(86, 31);
            runReport.TabIndex = 2;
            runReport.Text = "Run Report";
            runReport.UseVisualStyleBackColor = true;
            runReport.Click += runReport_Click;
            // 
            // reports
            // 
            reports.FormattingEnabled = true;
            reports.ItemHeight = 20;
            reports.Items.AddRange(new object[] { "Report 1", "Report 2", "Report 3", "Report 4", "Report 5" });
            reports.Location = new Point(1015, 41);
            reports.Margin = new Padding(3, 4, 3, 4);
            reports.Name = "reports";
            reports.Size = new Size(130, 224);
            reports.TabIndex = 1;
            // 
            // reportOutputText
            // 
            reportOutputText.Location = new Point(3, 4);
            reportOutputText.Margin = new Padding(3, 4, 3, 4);
            reportOutputText.Name = "reportOutputText";
            reportOutputText.Size = new Size(956, 419);
            reportOutputText.TabIndex = 0;
            reportOutputText.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 539);
            Controls.Add(first_tab);
            Margin = new Padding(3, 4, 3, 4);
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
        private Button addMoviebutton;
        private TextBox addMoviebox;
        private TextBox assignActorbox;
        private Button assignActorbutton;
    }
}