using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Audi : Car
    {
        private string Brand = "Audi";
        public string Model { get; set; }

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public void ShowDetail()
        {
            Console.WriteLine("Car's HP is " + this.HP);
            Console.WriteLine("Car's Color is " + this.Color);
            Console.WriteLine("car's Model is " + this.Model);
            Console.WriteLine("Car's Brand is " + Brand);
        }

        public override void Repair()
        {
            Console.WriteLine("Car was repaird!!");
        }
    }
}
