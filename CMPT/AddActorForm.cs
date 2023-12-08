using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT
{
    public partial class AddActorForm : Form
    {
        Form1 mainForm;
        int actorId;
        public AddActorForm(Form1 mainForm, int actorID)
        {
            this.mainForm = mainForm;
            this.actorId = actorID;
            InitializeComponent();
        }

        private void AddActorForm_Load(object sender, EventArgs e)
        {
            ActorIdText.Text = actorId.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActorStruct actorStruct = new ActorStruct(int.Parse(ActorIdText.Text))
            {
                lastName = ActorLastNameTextBox.Text,
                firstName = ActorFirstNameTextBox.Text,
                gender = ActorGenderComboBox.SelectedItem.ToString(),
                dateOfBirth = DateOfBirthDatePicker.Value,
                age = int.Parse(ActorAgeText.Text),
                rating = 0
            };

            mainForm.AddActor(new(actorStruct));

            this.Close();
        }

        private void DateOfBirthDatePicker_ValueChanged(object sender, EventArgs e)
        {
            ActorAgeText.Text = (new DateTime(DateTime.Now.Subtract(DateOfBirthDatePicker.Value).Ticks).Year - 1).ToString();
        }
    }
}
