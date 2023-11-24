using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public struct MovieStruct
    {
        public string id;
        public string name;
        public string genre;
        public string price;
        public string copies;
        public string rating;

        public MovieStruct(string movieId)
        {
            this.id = movieId;
        }
    }
}
