using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    public class SportsCar : Car
    {
        public string numberplate;

        public SportsCar(string name, float speed, string numberplate) : base(name, speed, numberplate)
        {
            this.numberplate = numberplate;
        }
    }
}
