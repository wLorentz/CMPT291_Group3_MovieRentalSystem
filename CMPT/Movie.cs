using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public class Movie
    {
        private string id;
        private string name;
        private string genre;
        private string price;
        private string copies;
        private string rating;

        public Movie(MovieStruct movieStruct) 
        {
            this.id = movieStruct.id;
            this.name = movieStruct.name;
            this.genre = movieStruct.genre;
            this.price = movieStruct.price;
            this.copies = movieStruct.copies;
            this.rating = movieStruct.rating;
        }

        public string getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public string getGenre()
        {
            return genre;
        }

        public string getPrice()
        {
            return price;
        }

        public string getCopies()
        {
            return copies;
        }

        public string getRating()
        {
            return rating;
        }
    }
}
