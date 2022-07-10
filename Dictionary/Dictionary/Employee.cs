using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string role, string name, int age, double salary)
        {
            Role = role;
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
