using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    public class Bike : Vehicle
    {
        public float bellVolume;

        public Bike(string name, float speed, float bellVolume) : base(name, speed, 2)
        {
            this.bellVolume = bellVolume;
        }

        public void RingBell()
        {
            Console.WriteLine($"{name} the {type} just ringed its bell at {bellVolume} decibels.");
        }
    }
}
