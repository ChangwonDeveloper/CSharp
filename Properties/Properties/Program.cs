using System;

namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);
            /*box.length = 3;
            box.height = 4;
            box.width = 5;*/
            box.DisplayInfo();
            box.SetLength(10);
            Console.WriteLine(box.GetLength());
            box.Height = -15;
            Console.WriteLine(box.Height);
            box.Width = 10;
            Console.WriteLine(box.Volume);
            Members members = new Members();
             
            members.Introducing(true);
            
            Console.ReadKey();
        }
    }
}
