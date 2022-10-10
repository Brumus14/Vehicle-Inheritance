using System;

namespace Vehicle_Inheritance
{
    class Program
    { 
        static void Main(string[] args)
        {
            Motorbike motorbikeJim = new Motorbike("Jim", 18, 80, "8JOX703");
            Convertible convertibleBiff = new Convertible("Biff", 23, "LVL0227");
            SportsCar sportsCarBinley = new SportsCar("Binley", 30, "416YWQ");

            motorbikeJim.DisplayInfo();
            Console.WriteLine();
            convertibleBiff.DisplayInfo();
            Console.WriteLine();
            sportsCarBinley.DisplayInfo();
            Console.WriteLine();

            Console.Write("How long should Jim drive for? ");
            motorbikeJim.Move(float.Parse(Console.ReadLine()));
            motorbikeJim.RingBell();
            Console.WriteLine();

            Console.Write("How long should Biff drive for? ");
            convertibleBiff.Move(float.Parse(Console.ReadLine()));
            convertibleBiff.ToggleRoof();
            convertibleBiff.Honk();
            Console.WriteLine();

            Console.Write("How long should Binley drive for? ");
            sportsCarBinley.Move(float.Parse(Console.ReadLine()));
            sportsCarBinley.Honk();
            Console.WriteLine();

            motorbikeJim.DisplayInfo();
            Console.WriteLine();
            convertibleBiff.DisplayInfo();
            Console.WriteLine();
            sportsCarBinley.DisplayInfo();
        }
    }
}