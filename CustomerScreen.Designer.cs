namespace CMPT
{
    partial class CustomerScreen
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
            allCustomers = new TabPage();
            Customers = new DataGridView();
            accountNo = new DataGridViewTextBoxColumn();
            accountType = new DataGridViewTextBoxColumn();
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
            CustomerDeleteButton = new Button();
            UpdateCustomersButton = new Button();
            SearchCustomerButton = new Button();
            SearchCustomerBox = new TextBox();
            first_tab = new TabControl();
            allCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Customers).BeginInit();
            first_tab.SuspendLayout();
            SuspendLayout();
            // 
            // allCustomers
            // 
            allCustomers.Controls.Add(Customers);
            allCustomers.Controls.Add(CustomerDeleteButton);
            allCustomers.Controls.Add(UpdateCustomersButton);
            allCustomers.Controls.Add(SearchCustomerButton);
            allCustomers.Controls.Add(SearchCustomerBox);
            allCustomers.Location = new Point(4, 24);
            allCustomers.Margin = new Padding(3, 2, 3, 2);
            allCustomers.Name = "allCustomers";
            allCustomers.Padding = new Padding(3, 2, 3, 2);
            allCustomers.Size = new Size(1151, 327);
            allCustomers.TabIndex = 0;
            allCustomers.Text = "Customers";
            allCustomers.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            Customers.AllowUserToAddRows = false;
            Customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Customers.Columns.AddRange(new DataGridViewColumn[] { accountNo, accountType, lastName, firstName, streetNumber, streetName, aptNumber, city, postalCode, phoneNumber, email, creditCard, rating });
            Customers.Location = new Point(0, 0);
            Customers.Name = "Customers";
            Customers.RowHeadersWidth = 51;
            Customers.RowTemplate.Height = 25;
            Customers.Size = new Size(1143, 296);
            Customers.TabIndex = 2;
            // 
            // accountNo
            // 
            accountNo.HeaderText = "Account Number";
            accountNo.Name = "accountNo";
            // 
            // accountType
            // 
            accountType.HeaderText = "Account Type";
            accountType.Name = "accountType";
            // 
            // lastName
            // 
            lastName.HeaderText = "Last Name";
            lastName.Name = "lastName";
            // 
            // firstName
            // 
            firstName.HeaderText = "First Name";
            firstName.Name = "firstName";
            // 
            // streetNumber
            // 
            streetNumber.HeaderText = "Street Number";
            streetNumber.Name = "streetNumber";
            // 
            // streetName
            // 
            streetName.HeaderText = "Street Name";
            streetName.Name = "streetName";
            // 
            // aptNumber
            // 
            aptNumber.HeaderText = "Apartment Number";
            aptNumber.Name = "aptNumber";
            // 
            // city
            // 
            city.HeaderText = "City";
            city.Name = "city";
            // 
            // postalCode
            // 
            postalCode.HeaderText = "Postal Code";
            postalCode.Name = "postalCode";
            // 
            // phoneNumber
            // 
            phoneNumber.HeaderText = "Phone Number";
            phoneNumber.Name = "phoneNumber";
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // creditCard
            // 
            creditCard.HeaderText = "Credit Card Number";
            creditCard.Name = "creditCard";
            // 
            // rating
            // 
            rating.HeaderText = "Rating";
            rating.Name = "rating";
            // 
            // CustomerDeleteButton
            // 
            CustomerDeleteButton.Location = new Point(760, 299);
            CustomerDeleteButton.Margin = new Padding(3, 2, 3, 2);
            CustomerDeleteButton.Name = "CustomerDeleteButton";
            CustomerDeleteButton.Size = new Size(82, 22);
            CustomerDeleteButton.TabIndex = 6;
            CustomerDeleteButton.Text = "Delete";
            CustomerDeleteButton.UseVisualStyleBackColor = true;
            CustomerDeleteButton.Click += CustomerDeleteButton_Click;
            // 
            // UpdateCustomersButton
            // 
            UpdateCustomersButton.Location = new Point(848, 299);
            UpdateCustomersButton.Margin = new Padding(3, 2, 3, 2);
            UpdateCustomersButton.Name = "UpdateCustomersButton";
            UpdateCustomersButton.Size = new Size(82, 22);
            UpdateCustomersButton.TabIndex = 5;
            UpdateCustomersButton.Text = "Update";
            UpdateCustomersButton.UseVisualStyleBackColor = true;
            UpdateCustomersButton.Click += UpdateCustomersButton_Click;
            // 
            // SearchCustomerButton
            // 
            SearchCustomerButton.Location = new Point(936, 299);
            SearchCustomerButton.Margin = new Padding(3, 2, 3, 2);
            SearchCustomerButton.Name = "SearchCustomerButton";
            SearchCustomerButton.Size = new Size(82, 22);
            SearchCustomerButton.TabIndex = 4;
            SearchCustomerButton.Text = "Search";
            SearchCustomerButton.UseVisualStyleBackColor = true;
            SearchCustomerButton.Click += SearchCustomerButton_Click;
            // 
            // SearchCustomerBox
            // 
            SearchCustomerBox.Location = new Point(1027, 299);
            SearchCustomerBox.Margin = new Padding(3, 2, 3, 2);
            SearchCustomerBox.Name = "SearchCustomerBox";
            SearchCustomerBox.Size = new Size(110, 23);
            SearchCustomerBox.TabIndex = 3;
            // 
            // first_tab
            // 
            first_tab.Controls.Add(allCustomers);
            first_tab.Location = new Point(2, 1);
            first_tab.Margin = new Padding(3, 2, 3, 2);
            first_tab.Name = "first_tab";
            first_tab.SelectedIndex = 0;
            first_tab.ShowToolTips = true;
            first_tab.Size = new Size(1159, 355);
            first_tab.TabIndex = 4;
            // 
            // CustomerScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 348);
            Controls.Add(first_tab);
            Name = "CustomerScreen";
            Text = "CustomerScreen";
            allCustomers.ResumeLayout(false);
            allCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Customers).EndInit();
            first_tab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage allCustomers;
        private Button CustomerDeleteButton;
        private Button UpdateCustomersButton;
        private Button SearchCustomerButton;
        private TextBox SearchCustomerBox;
        private DataGridView Customers;
        private DataGridViewTextBoxColumn accountNo;
        private DataGridViewTextBoxColumn accountType;
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
        private TabControl first_tab;
    }
}