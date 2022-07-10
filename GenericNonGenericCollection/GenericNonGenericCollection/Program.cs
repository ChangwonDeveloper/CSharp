using System;
using System.Collections;

namespace GenericNonGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // declaring an ArrayList
            // undefined amount of boject
            ArrayList myArrayList = new ArrayList();

            // defined amount of object
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(10);
            myArrayList.Add(10);
            myArrayList.Add("asf");
            myArrayList.Add(115.1235);
            myArrayList.Add(45.34f);

            // delete element with specific value from the arraylist
            myArrayList.Remove(10);

            // delete element at specific position
            myArrayList.RemoveAt(0);

            double sum = 0;
            foreach (object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if(obj is string)
                {
                    Console.WriteLine(obj);
                    
                }
                Console.WriteLine(sum);

            }
        }
    }
}
