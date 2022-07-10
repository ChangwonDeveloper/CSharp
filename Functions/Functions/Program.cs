using System;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Hello");
            Console.WriteLine(Add(10, 20));
            Console.WriteLine(multiply(10, 30));
            Console.WriteLine(divide(10, 40));
            GreetFriend("Chris");
            Console.WriteLine(Calculate());

            Console.Read();
        }
        
        // access modifier (static) return tytpe method name (parameter 1 parameter 2)
        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string something)
        {
            Console.WriteLine(something);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi! {0} my friend!", friendName);
        }

        public static int Calculate()
        {
            Console.WriteLine("Enter first num");
            string input = Console.ReadLine();
            Console.WriteLine("Enter second num");
            string input2 = Console.ReadLine();
            int result = Int32.Parse(input) + Int32.Parse(input2);
            return result;
        }
    }
}
