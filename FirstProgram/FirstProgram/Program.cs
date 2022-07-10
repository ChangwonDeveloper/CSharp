using System;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring a variable
            int num1;
            // assigning a value to a varaible
            num1 = 13;
            // declaring and initializing a variable in one go
            int num2 = 20;
            int sum = num1 + num2;

            Console.WriteLine(num1+num2);
            Console.WriteLine("num1: " + num1 + " + num2: " +num2 + " is " +sum);

            // declaring multiple variable at once
            int num3, num4, num5;
            Console.Read();
        }
    }
}