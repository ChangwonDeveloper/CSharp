using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = new int[5];
            grades[0] = 10;
            grades[1] = 20;
            grades[2] = 30;
            grades[3] = 40;
            grades[4] = 50;

            Console.WriteLine(grades[0]);

            int input = int.Parse(Console.ReadLine());
            // assign value to arry at index 0
            grades[0] = input;
            Console.WriteLine(grades[0]);

            // another way of initializing an array
            int[] gradesOfMAthStudentsA = { 10, 20, 30, 40 };

            // third way of initializing an array
            int[] gradespfMathStudentsB = new int[] { 15, 20, 3, 16 };

            Console.WriteLine(gradesOfMAthStudentsA.Length);
            Console.WriteLine("=======================");
            int[] num = new int[10];
            for(int i = 0; i < 10; i++)
            {
                num[i] = i;
            }
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            double[] num2 = new double[10];
            for(int i = 0; i < 10; i++)
            {
                num2[i] = i + 0.1;
            }
            foreach(double i in num2)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
