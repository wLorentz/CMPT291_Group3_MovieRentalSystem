using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public struct ActorStruct
    {
        public int id;
        public string lastName;
        public string firstName;
        public string gender;
        public DateTime dateOfBirth;
        public int age;
        public int rating;

        public ActorStruct (int id)
        {
            this.id = id;
        }
    }
}
