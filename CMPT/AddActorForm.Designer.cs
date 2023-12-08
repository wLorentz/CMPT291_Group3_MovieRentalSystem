namespace CMPT
{
    partial class AddActorForm
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
            label1 = new Label();
            ActorIdText = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            ActorLastNameTextBox = new TextBox();
            ActorFirstNameTextBox = new TextBox();
            ActorGenderComboBox = new ComboBox();
            DateOfBirthDatePicker = new DateTimePicker();
            ActorAgeText = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 31);
            label1.TabIndex = 0;
            label1.Text = "Actor ID:";
            // 
            // ActorIdText
            // 
            ActorIdText.AutoSize = true;
            ActorIdText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActorIdText.Location = new Point(165, 9);
            ActorIdText.Name = "ActorIdText";
            ActorIdText.Size = new Size(36, 31);
            ActorIdText.TabIndex = 1;
            ActorIdText.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(129, 31);
            label3.TabIndex = 3;
            label3.Text = "First Name:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 159);
            label4.Name = "label4";
            label4.Size = new Size(94, 31);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 204);
            label5.Name = "label5";
            label5.Size = new Size(147, 31);
            label5.TabIndex = 5;
            label5.Text = "Date of Birth:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 257);
            label6.Name = "label6";
            label6.Size = new Size(60, 31);
            label6.TabIndex = 6;
            label6.Text = "Age:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 396);
            button1.Name = "button1";
            button1.Size = new Size(94, 42);
            button1.TabIndex = 7;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ActorLastNameTextBox
            // 
            ActorLastNameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActorLastNameTextBox.Location = new Point(165, 57);
            ActorLastNameTextBox.Name = "ActorLastNameTextBox";
            ActorLastNameTextBox.Size = new Size(250, 38);
            ActorLastNameTextBox.TabIndex = 8;
            // 
            // ActorFirstNameTextBox
            // 
            ActorFirstNameTextBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActorFirstNameTextBox.Location = new Point(165, 103);
            ActorFirstNameTextBox.Name = "ActorFirstNameTextBox";
            ActorFirstNameTextBox.Size = new Size(250, 38);
            ActorFirstNameTextBox.TabIndex = 9;
            // 
            // ActorGenderComboBox
            // 
            ActorGenderComboBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActorGenderComboBox.FormattingEnabled = true;
            ActorGenderComboBox.Items.AddRange(new object[] { "M", "F" });
            ActorGenderComboBox.Location = new Point(165, 156);
            ActorGenderComboBox.Name = "ActorGenderComboBox";
            ActorGenderComboBox.Size = new Size(79, 39);
            ActorGenderComboBox.TabIndex = 10;
            // 
            // DateOfBirthDatePicker
            // 
            DateOfBirthDatePicker.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            DateOfBirthDatePicker.Location = new Point(165, 204);
            DateOfBirthDatePicker.Name = "DateOfBirthDatePicker";
            DateOfBirthDatePicker.Size = new Size(250, 38);
            DateOfBirthDatePicker.TabIndex = 11;
            DateOfBirthDatePicker.ValueChanged += DateOfBirthDatePicker_ValueChanged;
            // 
            // ActorAgeText
            // 
            ActorAgeText.AutoSize = true;
            ActorAgeText.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            ActorAgeText.Location = new Point(165, 257);
            ActorAgeText.Name = "ActorAgeText";
            ActorAgeText.Size = new Size(26, 31);
            ActorAgeText.TabIndex = 12;
            ActorAgeText.Text = "0";
            // 
            // AddActorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ActorAgeText);
            Controls.Add(DateOfBirthDatePicker);
            Controls.Add(ActorGenderComboBox);
            Controls.Add(ActorFirstNameTextBox);
            Controls.Add(ActorLastNameTextBox);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(ActorIdText);
            Controls.Add(label1);
            Name = "AddActorForm";
            Text = "AddActorForm";
            Load += AddActorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label ActorIdText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private TextBox ActorLastNameTextBox;
        private TextBox ActorFirstNameTextBox;
        private ComboBox ActorGenderComboBox;
        private DateTimePicker DateOfBirthDatePicker;
        private Label ActorAgeText;
    }
}