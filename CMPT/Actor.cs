using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPT
{
    public class Actor
    {
        private int id;
        private string lastName;
        private string firstName;
        private string gender;
        private DateTime dateOfBirth;
        private int age;
        private int rating;
        
        public Actor(ActorStruct actorStruct)
        { 
            id = actorStruct.id;
            lastName = actorStruct.lastName;
            firstName = actorStruct.firstName;
            gender = actorStruct.gender;
            dateOfBirth = actorStruct.dateOfBirth;
            age = actorStruct.age;
            rating = actorStruct.rating;
        }

        public int Id { get { return id; } }
        public string LastName { get { return lastName; } }
        public string FirstName { get { return firstName; } }
        public string Gender { get {  return gender; } }
        public DateTime DateOfBirth { get {  return dateOfBirth; } }
        public int Age { get { return age; } }
        public int Rating { get { return rating;} }
    }
}
