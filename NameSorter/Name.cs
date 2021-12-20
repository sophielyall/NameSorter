using System;
namespace NameSorter
{
    public class Name
    {

        public string firstName { get; }
        public string lastName { get; }
        public Name(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string getFullName()
        {
            return firstName + " " + lastName;
        }

        
    }
}
