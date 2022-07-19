using System;

namespace Param
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParamsMethod("asd", "asd", "sadgsd", "sdfg", "fsg", "....");
            Console.WriteLine("===========");
            ParamsMethod2("sdgsdg", 124, 135.5);
            int min = MinV2(6, 3, 4, 56, 342, 12, 14, 1, 0, 12);
        }
        // param allows us to pass into as many as argument we want
        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
            Console.WriteLine();
        }
        public static void ParamsMethod2(params object[] stuff)
        {
            foreach(object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int number in numbers)
            {
                if(number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
            return min;
        }
    }
}