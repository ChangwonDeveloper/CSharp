using System;

namespace ErorrHnadling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, plase enter the correct type next time");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Too large number to handle");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The value is empty");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error");
            }
            finally
            {
                // code should be executed whether there is error or not
                Console.WriteLine("This is called anyway");
            }

            try
            {
                int num1 = 24;
                int num2 = 0;
                Console.WriteLine(num1/num2);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divided by zero");

            }

            Console.ReadKey();
        }
    }
}
