using System;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to part in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }
        }
    }
}
