using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Time___15_Minutes
{
    class TimePlus15Mins
    {
        static void Main()
        {
            Console.WriteLine("This will read input from user for hour and mins (in hh:mm format), and will display what the time will be in 15 minutes.");
            Console.WriteLine();

            Console.Write("Please enter hour: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Please enter minutes: ");
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;

            if (minutes > 59)
            {
                minutes -= 60;
                hours += 1;
            }
            if (hours > 23)
            {
                hours = 0;
            }

            if (minutes < 10)
            {
                Console.WriteLine("{0}:0{1}", hours, minutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutes);
            }
        }
    }
}
