using System;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare 2D array
            string[,] matrix;

            // declare 3D array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,] 
            {
                {1,2,3},    // row 0
                {3,4,5 },   // row 1
                {7,8,9 }    // row 2
            };

            Console.WriteLine("Central value is {0}", array2D[1,1]);

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001" },
                    {"010", "011" },
                    {"Hi there", "last entry" }
                },
                {
                    {"100", "101" },
                    {"110", "111" },
                    {"another one", "last entry" }
                }
            };

            Console.WriteLine("The value is {0}", array3D[1,2,0]);

            // another way;
            string[,] array2DString = new string[3, 2] { { "one", "two" }, { "three", "four" }, { "five", "six" } };

            string[,] array2DString2 = new string[1, 1];

            int dimension = array2DString.Rank;
            Console.WriteLine(dimension);
            Console.WriteLine("-------------------");
            foreach(int i in array2D)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Nested for loop for 2D array");

            // Nested for loop
            // outer for loop
            for (int i = 0; i < array2D.GetLength(0); i++)
            {
                // inner for loop
                for (int j = 0; j < array2D.GetLength(1); j++)
                {
                    if(array2D[i,j] % 2 == 1)
                    {
                        Console.Write(array2D[i,j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
