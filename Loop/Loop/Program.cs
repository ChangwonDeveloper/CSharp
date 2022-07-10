using System;

namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double average = 0;
            double input = 0;
            int count = 0;
            while(true)
            {
                Console.WriteLine("Enter the score");
                bool check_num = double.TryParse(Console.ReadLine(), out input);
                if(input == -1)
                {
                    average = sum / count;
                    break;
                }
                else if(check_num && input >= 0 && input <= 20)
                {
                    sum += input;
                    count++;
                    continue;
                }
                else
                {
                    Console.WriteLine("Please enter the number in correct format");
                }
            }
            Console.WriteLine("Sum of score is {0}", sum);
            Console.WriteLine("Number of subjects are {0}", average);
            Console.WriteLine("Average score is {0}", average);
        }
    }
}
