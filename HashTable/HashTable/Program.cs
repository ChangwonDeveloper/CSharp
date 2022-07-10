using System;
using System.Collections;

namespace HashTable
{
    internal class Program
    {
        // Key - Value
        // Auto - Car
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Maria", 98);
            Student stud2 = new Student(2, "Jason", 98);
            Student stud3 = new Student(3, "Clara", 98);
            Student stud4 = new Student(4, "Steve", 98);
            Student stud5 = new Student(5, "Chris", 98);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);
            studentsTable.Add(stud5.Id, stud5);

            // retrieve individual item with known ID
            Student storedStudent1 = (Student)studentsTable[stud1.Id];

            // retriveve all values from a hashtable
            foreach (DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID : {0}, Name : {1}, GPA : {2}", temp.Id, temp.Name, temp.GPA);
            }
            Console.WriteLine("=================");

            foreach (Student student in studentsTable.Values)
            {
                Console.WriteLine("Student ID : {0}, Name : {1}, GPA : {2}", student.Id, student.Name, student.GPA);

            }

        }
    }

}
