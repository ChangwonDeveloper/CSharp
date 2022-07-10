using System;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // create an object of my class
            // an instance of Human;
            Human chris = new Human("chris", "Chun");
            // access public variable from outside, and even change it
            // call it from outside of class
            chris.IntroduceMyself();

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
