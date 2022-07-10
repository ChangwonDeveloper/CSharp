using System;

namespace ForeachAndSwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter value");
            string inputValue = Console.ReadLine();
            int[] inputType = { 1, 2, 3 };
            foreach (int i in inputType)
            {
                printInfo(inputValue, i);

            }

        }

        static void printInfo(string inputValue, int inputType)
        {
            switch(inputType)
            {
                case 1:
                    {
                        Console.WriteLine("Yes! {0} you entered is string!", inputValue);
                        break;
                    }
                case 2:
                    {
                        int toInteger;
                        bool check = int.TryParse(inputValue, out toInteger);
                        if(check)
                        {
                            Console.WriteLine("Yes! {0} you entered is integer!", inputValue);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No! {0} you entered is not integer!", inputValue);
                            break;
                        }
                    }
                case 3:
                    {
                        if(inputValue == "True" || inputValue == "False" )
                        {
                            Console.WriteLine("Yes! {0} you entered is bool!", inputValue);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("NO! {0} you entered is not bool!", inputValue);
                            break;
                        }
                    }
            }
        }
    }
}
