using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    public class Convertible : Car
    {
        bool roofOpen = false;

        public Convertible(string name, float speed, string numberplate) : base(name, speed, numberplate)
        {

        }

        public void ToggleRoof()
        {
            roofOpen = !roofOpen;

            string roofVerb = roofOpen ? "opened" : "closed";

            if (roofOpen)
            {
                Console.WriteLine($"{name} the {type} {roofVerb} its roof.");
            }
        }
    }
}
