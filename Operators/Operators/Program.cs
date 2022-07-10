﻿using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            // unary operators
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunnt? {0}", !isSunny);

            // inrement operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            //preincrement
            Console.WriteLine("num is {0}", ++num);

            // decrement
            num--;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num--);
            // pre decrement
            Console.WriteLine("num is {0}", --num);

            int result = num1 + num2;
            Console.WriteLine("result of num1+num2 is {0}", result);

            // relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("result of num1 < num2 is {0}", isLower);

            // equality operator
            bool isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);
            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);

            // conditional operators
            bool isLowerAndSunny;

            // condition1 AND condition2
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("result of islower and issunny is {0}", isLowerAndSunny);

            // condition1 or condition2
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("result of islower or issunny is {0}", isLowerAndSunny);
            Console.ReadKey();
        }
    }
}
