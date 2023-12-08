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
            makeCopybox = new TextBox();
            makeCopybutton = new Button();
            addMoviebutton = new Button();
            movieDeletebutton = new Button();
            updateMoviesbutton = new Button();
            searchMoviebutton = new Button();
            searchMoviebox = new TextBox();
            actorTab = new TabPage();
            ActorGridView = new DataGridView();
            actorID = new DataGridViewTextBoxColumn();
            actorLastName = new DataGridViewTextBoxColumn();
            actorFirstName = new DataGridViewTextBoxColumn();
            actorGender = new DataGridViewTextBoxColumn();
            actorDateOfBirth = new DataGridViewTextBoxColumn();
            actorAge = new DataGridViewTextBoxColumn();
            actorRating = new DataGridViewTextBoxColumn();
            runReports = new TabPage();
            runReport = new Button();
            reports = new ListBox();
            reportOutputText = new RichTextBox();
            UserIDLabel = new Label();
            LogoutButton = new Button();
            EmployeesButton = new Button();
            AddActorButton = new Button();
            ((System.ComponentModel.ISupportInitialize)movies).BeginInit();
            first_tab.SuspendLayout();
            rentals.SuspendLayout();
            allCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomersGridView).BeginInit();
            allMovies.SuspendLayout();
            actorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ActorGridView).BeginInit();
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
            movies.Size = new Size(1315, 444);
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
            first_tab.Controls.Add(actorTab);
            first_tab.Controls.Add(runReports);
            first_tab.Location = new Point(-1, 80);
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
            button1.Click += button1_Click;
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
            // allCustomers
            // 
            allCustomers.Controls.Add(label5);
            allCustomers.Controls.Add(SearchByComboBox);
            allCustomers.Controls.Add(button2);
            allCustomers.Controls.Add(CustomerDeleteButton);
            allCustomers.Controls.Add(SearchCustomerButton);
            allCustomers.Controls.Add(SearchCustomerBox);
            allCustomers.Controls.Add(CustomersGridView);
            allCustomers.Location = new Point(4, 29);
            allCustomers.Margin = new Padding(3, 4, 3, 4);
            allCustomers.Name = "allCustomers";
            allCustomers.Size = new Size(1317, 496);
            allCustomers.TabIndex = 3;
            allCustomers.Text = "Customers";
            allCustomers.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(897, 459);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 13;
            label5.Text = "Search By:";
            // 
            // SearchByComboBox
            // 
            SearchByComboBox.FormattingEnabled = true;
            SearchByComboBox.Location = new Point(974, 453);
            SearchByComboBox.Name = "SearchByComboBox";
            SearchByComboBox.Size = new Size(121, 28);
            SearchByComboBox.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(10, 451);
            button2.Name = "button2";
            button2.Size = new Size(82, 32);
            button2.TabIndex = 11;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += addCustomerButton_Click;
            // 
            // CustomerDeleteButton
            // 
            CustomerDeleteButton.Location = new Point(99, 451);
            CustomerDeleteButton.Name = "CustomerDeleteButton";
            CustomerDeleteButton.Size = new Size(82, 32);
            CustomerDeleteButton.TabIndex = 10;
            CustomerDeleteButton.Text = "Delete";
            CustomerDeleteButton.UseVisualStyleBackColor = true;
            CustomerDeleteButton.Click += CustomerDeleteButton_Click;
            // 
            // SearchCustomerButton
            // 
            SearchCustomerButton.Location = new Point(1102, 453);
            SearchCustomerButton.Name = "SearchCustomerButton";
            SearchCustomerButton.Size = new Size(82, 32);
            SearchCustomerButton.TabIndex = 8;
            SearchCustomerButton.Text = "Search";
            SearchCustomerButton.UseVisualStyleBackColor = true;
            SearchCustomerButton.Click += SearchCustomerButton_Click;
            // 
            // SearchCustomerBox
            // 
            SearchCustomerBox.Location = new Point(1191, 455);
            SearchCustomerBox.Name = "SearchCustomerBox";
            SearchCustomerBox.Size = new Size(110, 27);
            SearchCustomerBox.TabIndex = 7;
            // 
            // CustomersGridView
            // 
            CustomersGridView.AllowUserToAddRows = false;
            CustomersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomersGridView.Columns.AddRange(new DataGridViewColumn[] { accountNo, lastName, firstName, streetNumber, streetName, aptNumber, city, postalCode, phoneNumber, email, creditCard, rating });
            CustomersGridView.Location = new Point(0, 0);
            CustomersGridView.Name = "CustomersGridView";
            CustomersGridView.ReadOnly = true;
            CustomersGridView.RowHeadersWidth = 51;
            CustomersGridView.RowTemplate.Height = 25;
            CustomersGridView.Size = new Size(1315, 445);
            CustomersGridView.TabIndex = 3;
            CustomersGridView.CellDoubleClick += Customers_CellDoubleClick;
            // 
            // accountNo
            // 
            accountNo.HeaderText = "Account Number";
            accountNo.MinimumWidth = 6;
            accountNo.Name = "accountNo";
            accountNo.ReadOnly = true;
            // 
            // lastName
            // 
            lastName.HeaderText = "Last Name";
            lastName.MinimumWidth = 6;
            lastName.Name = "lastName";
            lastName.ReadOnly = true;
            // 
            // firstName
            // 
            firstName.HeaderText = "First Name";
            firstName.MinimumWidth = 6;
            firstName.Name = "firstName";
            firstName.ReadOnly = true;
            // 
            // streetNumber
            // 
            streetNumber.HeaderText = "Street Number";
            streetNumber.MinimumWidth = 6;
            streetNumber.Name = "streetNumber";
            streetNumber.ReadOnly = true;
            // 
            // streetName
            // 
            streetName.HeaderText = "Street Name";
            streetName.MinimumWidth = 6;
            streetName.Name = "streetName";
            streetName.ReadOnly = true;
            // 
            // aptNumber
            // 
            aptNumber.HeaderText = "Apartment Number";
            aptNumber.MinimumWidth = 6;
            aptNumber.Name = "aptNumber";
            aptNumber.ReadOnly = true;
            // 
            // city
            // 
            city.HeaderText = "City";
            city.MinimumWidth = 6;
            city.Name = "city";
            city.ReadOnly = true;
            // 
            // postalCode
            // 
            postalCode.HeaderText = "Postal Code";
            postalCode.MinimumWidth = 6;
            postalCode.Name = "postalCode";
            postalCode.ReadOnly = true;
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Phone Number";
            phoneNumber.MinimumWidth = 6;
            phoneNumber.Name = "phoneNumber";
            phoneNumber.ReadOnly = true;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // creditCard
            // 
            creditCard.HeaderText = "Credit Card Number";
            creditCard.MinimumWidth = 6;
            creditCard.Name = "creditCard";
            creditCard.ReadOnly = true;
            // 
            // rating
            // 
            rating.HeaderText = "Rating";
            rating.MinimumWidth = 6;
            rating.Name = "rating";
            rating.ReadOnly = true;
            // 
            // allMovies
            // 
            allMovies.Controls.Add(makeCopybox);
            allMovies.Controls.Add(makeCopybutton);
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
            // makeCopybox
            // 
            makeCopybox.Location = new Point(865, 455);
            makeCopybox.Name = "makeCopybox";
            makeCopybox.Size = new Size(125, 27);
            makeCopybox.TabIndex = 12;
            makeCopybox.Text = "Enter Amount";
            makeCopybox.Click += makeCopybox_Click;
            // 
            // makeCopybutton
            // 
            makeCopybutton.Location = new Point(746, 452);
            makeCopybutton.Name = "makeCopybutton";
            makeCopybutton.Size = new Size(113, 32);
            makeCopybutton.TabIndex = 11;
            makeCopybutton.Text = "Make Copy: ";
            makeCopybutton.UseVisualStyleBackColor = true;
            makeCopybutton.Click += makeCopybutton_Click;
            // 
            // addMoviebutton
            // 
            addMoviebutton.Location = new Point(10, 452);
            addMoviebutton.Name = "addMoviebutton";
            addMoviebutton.Size = new Size(82, 32);
            addMoviebutton.TabIndex = 7;
            addMoviebutton.Text = "Add";
            addMoviebutton.UseVisualStyleBackColor = true;
            addMoviebutton.Click += addMoviebutton_Click;
            // 
            // movieDeletebutton
            // 
            movieDeletebutton.Location = new Point(98, 452);
            movieDeletebutton.Name = "movieDeletebutton";
            movieDeletebutton.Size = new Size(82, 32);
            movieDeletebutton.TabIndex = 6;
            movieDeletebutton.Text = "Delete";
            movieDeletebutton.UseVisualStyleBackColor = true;
            movieDeletebutton.Click += movieDeletebutton_Click;
            // 
            // updateMoviesbutton
            // 
            updateMoviesbutton.Location = new Point(1003, 452);
            updateMoviesbutton.Name = "updateMoviesbutton";
            updateMoviesbutton.Size = new Size(82, 32);
            updateMoviesbutton.TabIndex = 5;
            updateMoviesbutton.Text = "Update";
            updateMoviesbutton.UseVisualStyleBackColor = true;
            updateMoviesbutton.Click += updateMoviesbutton_Click;
            // 
            // searchMoviebutton
            // 
            searchMoviebutton.Location = new Point(1091, 452);
            searchMoviebutton.Name = "searchMoviebutton";
            searchMoviebutton.Size = new Size(82, 32);
            searchMoviebutton.TabIndex = 4;
            searchMoviebutton.Text = "Search";
            searchMoviebutton.UseVisualStyleBackColor = true;
            searchMoviebutton.Click += searchMoviebutton_Click;
            // 
            // searchMoviebox
            // 
            searchMoviebox.Location = new Point(1181, 453);
            searchMoviebox.Name = "searchMoviebox";
            searchMoviebox.Size = new Size(125, 27);
            searchMoviebox.TabIndex = 3;
            // 
            // actorTab
            // 
            actorTab.Controls.Add(AddActorButton);
            actorTab.Controls.Add(ActorGridView);
            actorTab.Location = new Point(4, 29);
            actorTab.Name = "actorTab";
            actorTab.Size = new Size(1317, 496);
            actorTab.TabIndex = 4;
            actorTab.Text = "Actors";
            actorTab.UseVisualStyleBackColor = true;
            // 
            // ActorGridView
            // 
            ActorGridView.AllowUserToAddRows = false;
            ActorGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ActorGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ActorGridView.Columns.AddRange(new DataGridViewColumn[] { actorID, actorLastName, actorFirstName, actorGender, actorDateOfBirth, actorAge, actorRating });
            ActorGridView.Location = new Point(1, 26);
            ActorGridView.Name = "ActorGridView";
            ActorGridView.ReadOnly = true;
            ActorGridView.RowHeadersWidth = 51;
            ActorGridView.RowTemplate.Height = 25;
            ActorGridView.Size = new Size(1315, 426);
            ActorGridView.TabIndex = 4;
            // 
            // actorID
            // 
            actorID.HeaderText = "Actor ID";
            actorID.MinimumWidth = 6;
            actorID.Name = "actorID";
            actorID.ReadOnly = true;
            // 
            // actorLastName
            // 
            actorLastName.HeaderText = "Last Name";
            actorLastName.MinimumWidth = 6;
            actorLastName.Name = "actorLastName";
            actorLastName.ReadOnly = true;
            // 
            // actorFirstName
            // 
            actorFirstName.HeaderText = "First Name";
            actorFirstName.MinimumWidth = 6;
            actorFirstName.Name = "actorFirstName";
            actorFirstName.ReadOnly = true;
            // 
            // actorGender
            // 
            actorGender.HeaderText = "Gender";
            actorGender.MinimumWidth = 6;
            actorGender.Name = "actorGender";
            actorGender.ReadOnly = true;
            // 
            // actorDateOfBirth
            // 
            actorDateOfBirth.HeaderText = "Date of Birth";
            actorDateOfBirth.MinimumWidth = 6;
            actorDateOfBirth.Name = "actorDateOfBirth";
            actorDateOfBirth.ReadOnly = true;
            // 
            // actorAge
            // 
            actorAge.HeaderText = "Age";
            actorAge.MinimumWidth = 6;
            actorAge.Name = "actorAge";
            actorAge.ReadOnly = true;
            // 
            // actorRating
            // 
            actorRating.HeaderText = "Rating";
            actorRating.MinimumWidth = 6;
            actorRating.Name = "actorRating";
            actorRating.ReadOnly = true;
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
            // UserIDLabel
            // 
            UserIDLabel.AutoSize = true;
            UserIDLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserIDLabel.Location = new Point(13, 12);
            UserIDLabel.Name = "UserIDLabel";
            UserIDLabel.Size = new Size(53, 46);
            UserIDLabel.TabIndex = 4;
            UserIDLabel.Text = "ID";
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LogoutButton.Location = new Point(1203, 16);
            LogoutButton.Margin = new Padding(3, 4, 3, 4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(102, 53);
            LogoutButton.TabIndex = 5;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // EmployeesButton
            // 
            EmployeesButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeesButton.Location = new Point(1041, 16);
            EmployeesButton.Margin = new Padding(3, 4, 3, 4);
            EmployeesButton.Name = "EmployeesButton";
            EmployeesButton.Size = new Size(133, 53);
            EmployeesButton.TabIndex = 6;
            EmployeesButton.Text = "Employees";
            EmployeesButton.UseMnemonic = false;
            EmployeesButton.UseVisualStyleBackColor = true;
            EmployeesButton.Click += EmployeesButton_Click;
            // 
            // AddActorButton
            // 
            AddActorButton.Location = new Point(9, 458);
            AddActorButton.Name = "AddActorButton";
            AddActorButton.Size = new Size(94, 29);
            AddActorButton.TabIndex = 5;
            AddActorButton.Text = "Add";
            AddActorButton.UseVisualStyleBackColor = true;
            AddActorButton.Click += AddActorButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 609);
            Controls.Add(EmployeesButton);
            Controls.Add(LogoutButton);
            Controls.Add(UserIDLabel);
            Controls.Add(first_tab);
            Margin = new Padding(3, 4, 3, 4);
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
            actorTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ActorGridView).EndInit();
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
        private TextBox makeCopybox;
        private Button makeCopybutton;
        private TabPage actorTab;
        private DataGridView ActorGridView;
        private DataGridViewTextBoxColumn actorID;
        private DataGridViewTextBoxColumn actorLastName;
        private DataGridViewTextBoxColumn actorFirstName;
        private DataGridViewTextBoxColumn actorGender;
        private DataGridViewTextBoxColumn actorDateOfBirth;
        private DataGridViewTextBoxColumn actorAge;
        private DataGridViewTextBoxColumn actorRating;
        private Button AddActorButton;
    }
}