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
            allCustomers = new TabPage();
            label5 = new Label();
            SearchByComboBox = new ComboBox();
            button2 = new Button();
            CustomerDeleteButton = new Button();
            SearchCustomerButton = new Button();
            SearchCustomerBox = new TextBox();
            CustomersGridView = new DataGridView();
            accountNo = new DataGridViewTextBoxColumn();
            lastName = new DataGridViewTextBoxColumn();
            firstName = new DataGridViewTextBoxColumn();
            streetNumber = new DataGridViewTextBoxColumn();
            streetName = new DataGridViewTextBoxColumn();
            aptNumber = new DataGridViewTextBoxColumn();
            city = new DataGridViewTextBoxColumn();
            postalCode = new DataGridViewTextBoxColumn();
            phoneNumber = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            creditCard = new DataGridViewTextBoxColumn();
            rating = new DataGridViewTextBoxColumn();
            allMovies = new TabPage();
            assignActorbox = new TextBox();
            assignActorbutton = new Button();
            addMoviebutton = new Button();
            movieDeletebutton = new Button();
            updateMoviesbutton = new Button();
            searchMoviebutton = new Button();
            searchMoviebox = new TextBox();
            runReports = new TabPage();
            runReport = new Button();
            reports = new ListBox();
            reportOutputText = new RichTextBox();
            UserIDLabel = new Label();
            LogoutButton = new Button();
            EmployeesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)movies).BeginInit();
            first_tab.SuspendLayout();
            rentals.SuspendLayout();
            allCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGridView).BeginInit();
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
            movies.Size = new Size(1151, 333);
            movies.TabIndex = 2;
            // 
            // movieIDs
            // 
            movieIDs.FillWeight = 110.4278F;
            movieIDs.HeaderText = "Movie ID";
            movieIDs.MinimumWidth = 6;
            movieIDs.Name = "movieIDs";
            // 
            // movieTitles
            // 
            movieTitles.FillWeight = 110.4278F;
            movieTitles.HeaderText = "Movie Title";
            movieTitles.MinimumWidth = 6;
            movieTitles.Name = "movieTitles";
            // 
            // movieGenres
            // 
            movieGenres.FillWeight = 110.4278F;
            movieGenres.HeaderText = "Genre";
            movieGenres.MinimumWidth = 6;
            movieGenres.Name = "movieGenres";
            // 
            // moviePrices
            // 
            moviePrices.FillWeight = 110.4278F;
            moviePrices.HeaderText = "Price";
            moviePrices.MinimumWidth = 6;
            moviePrices.Name = "moviePrices";
            // 
            // movieCopies
            // 
            movieCopies.FillWeight = 110.4278F;
            movieCopies.HeaderText = "Copies";
            movieCopies.MinimumWidth = 6;
            movieCopies.Name = "movieCopies";
            // 
            // movieRatings
            // 
            movieRatings.FillWeight = 110.4278F;
            movieRatings.HeaderText = "Rating";
            movieRatings.MinimumWidth = 6;
            movieRatings.Name = "movieRatings";
            // 
            // first_tab
            // 
            first_tab.Controls.Add(rentals);
            first_tab.Controls.Add(allCustomers);
            first_tab.Controls.Add(allMovies);
            first_tab.Controls.Add(runReports);
            first_tab.Location = new Point(-1, 60);
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
            button1.Click += button1_Click;
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
            // allCustomers
            // 
            allCustomers.Controls.Add(label5);
            allCustomers.Controls.Add(SearchByComboBox);
            allCustomers.Controls.Add(button2);
            allCustomers.Controls.Add(CustomerDeleteButton);
            allCustomers.Controls.Add(SearchCustomerButton);
            allCustomers.Controls.Add(SearchCustomerBox);
            allCustomers.Controls.Add(CustomersGridView);
            allCustomers.Location = new Point(4, 24);
            allCustomers.Name = "allCustomers";
            allCustomers.Size = new Size(1151, 369);
            allCustomers.TabIndex = 3;
            allCustomers.Text = "Customers";
            allCustomers.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(785, 344);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 13;
            label5.Text = "Search By:";
            // 
            // SearchByComboBox
            // 
            SearchByComboBox.FormattingEnabled = true;
            SearchByComboBox.Location = new Point(852, 340);
            SearchByComboBox.Margin = new Padding(3, 2, 3, 2);
            SearchByComboBox.Name = "SearchByComboBox";
            SearchByComboBox.Size = new Size(106, 23);
            SearchByComboBox.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(9, 338);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(72, 24);
            button2.TabIndex = 11;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += addCustomerButton_Click;
            // 
            // CustomerDeleteButton
            // 
            CustomerDeleteButton.Location = new Point(87, 338);
            CustomerDeleteButton.Margin = new Padding(3, 2, 3, 2);
            CustomerDeleteButton.Name = "CustomerDeleteButton";
            CustomerDeleteButton.Size = new Size(72, 24);
            CustomerDeleteButton.TabIndex = 10;
            CustomerDeleteButton.Text = "Delete";
            CustomerDeleteButton.UseVisualStyleBackColor = true;
            CustomerDeleteButton.Click += CustomerDeleteButton_Click;
            // 
            // SearchCustomerButton
            // 
            SearchCustomerButton.Location = new Point(964, 340);
            SearchCustomerButton.Margin = new Padding(3, 2, 3, 2);
            SearchCustomerButton.Name = "SearchCustomerButton";
            SearchCustomerButton.Size = new Size(72, 24);
            SearchCustomerButton.TabIndex = 8;
            SearchCustomerButton.Text = "Search";
            SearchCustomerButton.UseVisualStyleBackColor = true;
            // 
            // SearchCustomerBox
            // 
            SearchCustomerBox.Location = new Point(1042, 341);
            SearchCustomerBox.Margin = new Padding(3, 2, 3, 2);
            SearchCustomerBox.Name = "SearchCustomerBox";
            SearchCustomerBox.Size = new Size(97, 23);
            SearchCustomerBox.TabIndex = 7;
            // 
            // CustomersGridView
            // 
            CustomersGridView.AllowUserToAddRows = false;
            CustomersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGridView.Columns.AddRange(new DataGridViewColumn[] { accountNo, lastName, firstName, streetNumber, streetName, aptNumber, city, postalCode, phoneNumber, email, creditCard, rating });
            CustomersGridView.Location = new Point(0, 0);
            CustomersGridView.Margin = new Padding(3, 2, 3, 2);
            CustomersGridView.Name = "CustomersGridView";
            CustomersGridView.ReadOnly = true;
            CustomersGridView.RowHeadersWidth = 51;
            CustomersGridView.RowTemplate.Height = 25;
            CustomersGridView.Size = new Size(1151, 334);
            CustomersGridView.TabIndex = 3;
            CustomersGridView.CellDoubleClick += Customers_CellDoubleClick;
            // 
            // accountNo
            // 
            accountNo.HeaderText = "Account Number";
            accountNo.Name = "accountNo";
            accountNo.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.HeaderText = "Last Name";
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // firstName
            // 
            firstName.HeaderText = "First Name";
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // streetNumber
            // 
            streetNumber.HeaderText = "Street Number";
            streetNumber.Name = "streetNumber";
            streetNumber.ReadOnly = true;
            // 
            // streetName
            // 
            streetName.HeaderText = "Street Name";
            streetName.Name = "streetName";
            streetName.ReadOnly = true;
            // 
            // aptNumber
            // 
            aptNumber.HeaderText = "Apartment Number";
            aptNumber.Name = "aptNumber";
            aptNumber.ReadOnly = true;
            // 
            // city
            // 
            city.HeaderText = "City";
            city.Name = "city";
            city.ReadOnly = true;
            // 
            // postalCode
            // 
            postalCode.HeaderText = "Postal Code";
            postalCode.Name = "postalCode";
            postalCode.ReadOnly = true;
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Phone Number";
            phoneNumber.Name = "phoneNumber";
            phoneNumber.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // creditCard
            // 
            creditCard.HeaderText = "Credit Card Number";
            creditCard.Name = "creditCard";
            creditCard.ReadOnly = true;
            // 
            // rating
            // 
            rating.HeaderText = "Rating";
            rating.Name = "rating";
            rating.ReadOnly = true;
            // 
            // allMovies
            // 
            allMovies.Controls.Add(assignActorbox);
            allMovies.Controls.Add(assignActorbutton);
            allMovies.Controls.Add(addMoviebutton);
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
            // assignActorbox
            // 
            assignActorbox.Location = new Point(106, 338);
            assignActorbox.Margin = new Padding(3, 2, 3, 2);
            assignActorbox.Name = "assignActorbox";
            assignActorbox.Size = new Size(110, 23);
            assignActorbox.TabIndex = 10;
            assignActorbox.Text = "Enter Actor ID";
            assignActorbox.Click += assignActorbox_Click;
            // 
            // assignActorbutton
            // 
            assignActorbutton.Location = new Point(3, 338);
            assignActorbutton.Margin = new Padding(3, 2, 3, 2);
            assignActorbutton.Name = "assignActorbutton";
            assignActorbutton.Size = new Size(97, 24);
            assignActorbutton.TabIndex = 9;
            assignActorbutton.Text = "Assign Actor:";
            assignActorbutton.UseVisualStyleBackColor = true;
            assignActorbutton.Click += assignActorbutton_Click;
            // 
            // addMoviebutton
            // 
            addMoviebutton.Location = new Point(724, 339);
            addMoviebutton.Margin = new Padding(3, 2, 3, 2);
            addMoviebutton.Name = "addMoviebutton";
            addMoviebutton.Size = new Size(72, 24);
            addMoviebutton.TabIndex = 7;
            addMoviebutton.Text = "Add";
            addMoviebutton.UseVisualStyleBackColor = true;
            addMoviebutton.Click += addMoviebutton_Click;
            // 
            // movieDeletebutton
            // 
            movieDeletebutton.Location = new Point(801, 339);
            movieDeletebutton.Margin = new Padding(3, 2, 3, 2);
            movieDeletebutton.Name = "movieDeletebutton";
            movieDeletebutton.Size = new Size(72, 24);
            movieDeletebutton.TabIndex = 6;
            movieDeletebutton.Text = "Delete";
            movieDeletebutton.UseVisualStyleBackColor = true;
            movieDeletebutton.Click += movieDeletebutton_Click;
            // 
            // updateMoviesbutton
            // 
            updateMoviesbutton.Location = new Point(878, 339);
            updateMoviesbutton.Margin = new Padding(3, 2, 3, 2);
            updateMoviesbutton.Name = "updateMoviesbutton";
            updateMoviesbutton.Size = new Size(72, 24);
            updateMoviesbutton.TabIndex = 5;
            updateMoviesbutton.Text = "Update";
            updateMoviesbutton.UseVisualStyleBackColor = true;
            updateMoviesbutton.Click += updateMoviesbutton_Click;
            // 
            // searchMoviebutton
            // 
            searchMoviebutton.Location = new Point(955, 339);
            searchMoviebutton.Margin = new Padding(3, 2, 3, 2);
            searchMoviebutton.Name = "searchMoviebutton";
            searchMoviebutton.Size = new Size(72, 24);
            searchMoviebutton.TabIndex = 4;
            searchMoviebutton.Text = "Search";
            searchMoviebutton.UseVisualStyleBackColor = true;
            searchMoviebutton.Click += searchMoviebutton_Click;
            // 
            // searchMoviebox
            // 
            searchMoviebox.Location = new Point(1033, 340);
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
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserIDLabel.Location = new Point(11, 9);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(43, 37);
            UserIDLabel.TabIndex = 4;
            UserIDLabel.Text = "ID";
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(1053, 12);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(89, 40);
            LogoutButton.TabIndex = 5;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeesButton.Location = new Point(911, 12);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(116, 40);
            EmployeesButton.TabIndex = 6;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseMnemonic = false;
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 457);
            Controls.Add(EmployeesButton);
            Controls.Add(LogoutButton);
            Controls.Add(UserIDLabel);
            Controls.Add(first_tab);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)movies).EndInit();
            first_tab.ResumeLayout(false);
            rentals.ResumeLayout(false);
            rentals.PerformLayout();
            allCustomers.ResumeLayout(false);
            allCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGridView).EndInit();
            allMovies.ResumeLayout(false);
            allMovies.PerformLayout();
            runReports.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView movies;

        private TabControl first_tab;
        private TabPage allMovies;
        private Button searchMoviebutton;
        private TextBox searchMoviebox;
        private Button updateMoviesbutton;
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
        private TextBox assignActorbox;
        private Button assignActorbutton;
        private TabPage allCustomers;
        private DataGridView CustomersGridView;
        private Label label5;
        private ComboBox SearchByComboBox;
        private Button button2;
        private Button CustomerDeleteButton;
        private Button SearchCustomerButton;
        private TextBox SearchCustomerBox;
        private DataGridViewTextBoxColumn accountNo;
        private DataGridViewTextBoxColumn lastName;
        private DataGridViewTextBoxColumn firstName;
        private DataGridViewTextBoxColumn streetNumber;
        private DataGridViewTextBoxColumn streetName;
        private DataGridViewTextBoxColumn aptNumber;
        private DataGridViewTextBoxColumn city;
        private DataGridViewTextBoxColumn postalCode;
        private DataGridViewTextBoxColumn phoneNumber;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn creditCard;
        private DataGridViewTextBoxColumn rating;
        private Label UserIDLabel;
        private Button LogoutButton;
        private Button EmployeesButton;
        private DataGridViewTextBoxColumn movieIDs;
        private DataGridViewTextBoxColumn movieTitles;
        private DataGridViewTextBoxColumn movieGenres;
        private DataGridViewTextBoxColumn moviePrices;
        private DataGridViewTextBoxColumn movieCopies;
        private DataGridViewTextBoxColumn movieRatings;

    }
}