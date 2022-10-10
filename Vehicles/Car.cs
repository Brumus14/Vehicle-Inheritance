using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    public class Car : Vehicle
    {
        string numberplate;

        public Car(string name, float speed, string numberplate) : base(name, speed, 4)
        {
            this.numberplate = numberplate;
        }

        public void Honk()
        {
            Console.WriteLine($"{name} the {type} honked.");
        }
    }
}
