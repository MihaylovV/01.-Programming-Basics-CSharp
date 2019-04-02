using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Speed_Info
{
    class SpeedInfo
    {
        static void Main()
        {
            Console.WriteLine("This will take a number from the user as an input - it will be the speed of a vehicle. Afterwards, based on the number, it will print out different information.");
            Console.WriteLine();

            Console.Write("Please enter your speed: ");
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (speed > 10 && speed <= 50)
            {
                Console.WriteLine("average");
            }
            else if (speed > 50 && speed <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (speed > 150 && speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
