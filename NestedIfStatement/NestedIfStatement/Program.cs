using System;

namespace NestedIfStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Enter your name");
            userName = Console.ReadLine();
            // string use .equal to compare each other
            if(isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Hi there, registered user");
                Console.WriteLine("Hi there, {0}", userName);
                Console.WriteLine("Hi there, Admin!");
            }
            if(isAdmin || isRegistered)
            {
                Console.WriteLine("You are logged in");
            }

            
        Console.Read();
        }
    }
}
