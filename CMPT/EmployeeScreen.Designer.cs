namespace CMPT
{
    partial class EmployeeScreen
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
            EmployeeDataGrid = new DataGridView();
            employeeID = new DataGridViewTextBoxColumn();
            SSN = new DataGridViewTextBoxColumn();
            employeeLastName = new DataGridViewTextBoxColumn();
            employeeFirstName = new DataGridViewTextBoxColumn();
            employeeStreetNo = new DataGridViewTextBoxColumn();
            employeeStreetName = new DataGridViewTextBoxColumn();
            emplyeeAptNo = new DataGridViewTextBoxColumn();
            employeeCity = new DataGridViewTextBoxColumn();
            employeeProvince = new DataGridViewTextBoxColumn();
            employeePostalCode = new DataGridViewTextBoxColumn();
            employeePhoneNumber = new DataGridViewTextBoxColumn();
            employeeStartDate = new DataGridViewTextBoxColumn();
            label6 = new Label();
            comboBox1 = new ComboBox();
            AddEmployeeButton = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).BeginInit();
            SuspendLayout();
            // 
            // EmployeeDataGrid
            // 
            EmployeeDataGrid.AllowUserToAddRows = false;
            EmployeeDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            EmployeeDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EmployeeDataGrid.Columns.AddRange(new DataGridViewColumn[] { employeeID, SSN, employeeLastName, employeeFirstName, employeeStreetNo, employeeStreetName, emplyeeAptNo, employeeCity, employeeProvince, employeePostalCode, employeePhoneNumber, employeeStartDate });
            EmployeeDataGrid.Location = new Point(12, 12);
            EmployeeDataGrid.Name = "EmployeeDataGrid";
            EmployeeDataGrid.RowHeadersWidth = 51;
            EmployeeDataGrid.RowTemplate.Height = 25;
            EmployeeDataGrid.Size = new Size(1143, 365);
            EmployeeDataGrid.TabIndex = 5;
            // 
            // employeeID
            // 
            employeeID.HeaderText = "ID";
            employeeID.Name = "employeeID";
            // 
            // SSN
            // 
            SSN.HeaderText = "SSN";
            SSN.Name = "SSN";
            // 
            // employeeLastName
            // 
            employeeLastName.HeaderText = "Last Name";
            employeeLastName.Name = "employeeLastName";
            // 
            // employeeFirstName
            // 
            employeeFirstName.HeaderText = "First Name";
            employeeFirstName.Name = "employeeFirstName";
            // 
            // employeeStreetNo
            // 
            employeeStreetNo.HeaderText = "Street Number";
            employeeStreetNo.Name = "employeeStreetNo";
            // 
            // employeeStreetName
            // 
            employeeStreetName.HeaderText = "Street Name";
            employeeStreetName.Name = "employeeStreetName";
            // 
            // emplyeeAptNo
            // 
            emplyeeAptNo.HeaderText = "Apt Number";
            emplyeeAptNo.Name = "emplyeeAptNo";
            // 
            // employeeCity
            // 
            employeeCity.HeaderText = "City";
            employeeCity.Name = "employeeCity";
            // 
            // employeeProvince
            // 
            employeeProvince.HeaderText = "Province";
            employeeProvince.Name = "employeeProvince";
            // 
            // employeePostalCode
            // 
            employeePostalCode.HeaderText = "Postal Code";
            employeePostalCode.Name = "employeePostalCode";
            // 
            // employeePhoneNumber
            // 
            employeePhoneNumber.HeaderText = "Phone Number";
            employeePhoneNumber.Name = "employeePhoneNumber";
            // 
            // employeeStartDate
            // 
            employeeStartDate.HeaderText = "Start Date";
            employeeStartDate.Name = "employeeStartDate";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(752, 404);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 25;
            label6.Text = "Search By:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(819, 401);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 24;
            // 
            // AddEmployeeButton
            // 
            AddEmployeeButton.Location = new Point(12, 402);
            AddEmployeeButton.Margin = new Padding(3, 2, 3, 2);
            AddEmployeeButton.Name = "AddEmployeeButton";
            AddEmployeeButton.Size = new Size(82, 24);
            AddEmployeeButton.TabIndex = 23;
            AddEmployeeButton.Text = "Add";
            AddEmployeeButton.UseVisualStyleBackColor = true;
            AddEmployeeButton.Click += AddEmployeeButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(100, 402);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(82, 24);
            button4.TabIndex = 22;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(946, 401);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 24);
            button5.TabIndex = 21;
            button5.Text = "Search";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1037, 401);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 20;
            // 
            // EmployeeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1171, 443);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(AddEmployeeButton);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(textBox1);
            Controls.Add(EmployeeDataGrid);
            Name = "EmployeeScreen";
            Text = "Employees";
            Load += EmployeeScreen_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView EmployeeDataGrid;
        private DataGridViewTextBoxColumn employeeID;
        private DataGridViewTextBoxColumn SSN;
        private DataGridViewTextBoxColumn employeeLastName;
        private DataGridViewTextBoxColumn employeeFirstName;
        private DataGridViewTextBoxColumn employeeStreetNo;
        private DataGridViewTextBoxColumn employeeStreetName;
        private DataGridViewTextBoxColumn emplyeeAptNo;
        private DataGridViewTextBoxColumn employeeCity;
        private DataGridViewTextBoxColumn employeeProvince;
        private DataGridViewTextBoxColumn employeePostalCode;
        private DataGridViewTextBoxColumn employeePhoneNumber;
        private DataGridViewTextBoxColumn employeeStartDate;
        private Label label6;
        private ComboBox comboBox1;
        private Button AddEmployeeButton;
        private Button button4;
        private Button button5;
        private TextBox textBox1;
    }
}