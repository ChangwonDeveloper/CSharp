using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hP, string color)
        {
            HP = hP;
            Color = color;
        }

        public void ShowDetail()
        {
            Console.WriteLine("Car's HP is " + this.HP);
            Console.WriteLine("Car's Color is " + this.Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car was repaird!!");
        }
    }
}
