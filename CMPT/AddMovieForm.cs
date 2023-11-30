using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT
{
    public partial class AddMovieForm : Form
    {
        Form1 mainForm;
        int movieID;

        public AddMovieForm(Form1 mainForm, int movieID)
        {
            this.mainForm = mainForm;
            this.movieID = movieID;
            InitializeComponent();
        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            MovieIdText.Text = this.movieID.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MovieStruct movieStruct = new(MovieIdText.Text)
            {
                name = MovieNameTextBox.Text,
                genre = GenreTextBox.Text,
                price = PriceTextBox.Text,
                copies = CopiesTextBox.Text,
                rating = "0"
            };

            mainForm.AddMovie(new Movie(movieStruct));

            this.Close();
        }
    }
}
