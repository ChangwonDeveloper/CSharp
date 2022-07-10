using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    // this class is a blueprint for a datatype
    internal class Human
    {
        // member variable
        
        private string firstName;
        private string lastName;

        // default constructor
        public Human()
        {
            Console.WriteLine("Constructor is called");
        }

        // parameterized constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName; 
            // or this.firstName
            Console.WriteLine("Parameterized Constructor is called");
        }

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
