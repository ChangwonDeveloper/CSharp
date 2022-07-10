using System;

namespace UsingArraysAsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gradesArray = { 12, 35, 54, 65, 24, 64, 19, 29, 49, 1};
            Console.WriteLine(GetAverage(gradesArray));
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
