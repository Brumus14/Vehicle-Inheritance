using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    public class Motorbike : Bike
    {
        public string numberplate;

        public Motorbike(string name, float speed, float bellVolume, string numberplate) : base(name, speed, bellVolume)
        {
            this.numberplate = numberplate;
        }
    }
}
