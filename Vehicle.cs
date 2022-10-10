using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Inheritance
{
    public class Vehicle
    {
        public string type;
        public float position = 0;
        public string name;
        public float speed;
        public int wheels;

        public Vehicle(string name, float speed, int wheels)
        {
            this.name = name;
            this.speed = speed;
            this.wheels = wheels;

            type = this.GetType().Name;
        }

        public void Move(float moveTime)
        {
            float moveDistance = speed * moveTime;
            position += moveDistance;
            Console.WriteLine($"{name} the {type} just moved {moveDistance}m. Its position is now {position}m.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}\nType: {type}\nPosition: {position}m\nSpeed: {speed}m/s\nWheels: {wheels}");
        }
        //numberplate
    }
}
