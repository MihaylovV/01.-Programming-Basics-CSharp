using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Choreography
{
    class Choreography
    {
        static void Main()
        {
            Console.WriteLine("This will calculate if D number of Dancers can learn N number of steps of a new dance for the input number of days.");
            Console.WriteLine();

            Console.Write("Please enter 'N' number of steps: ");
            double steps = double.Parse(Console.ReadLine());

            Console.Write("Please enter how many dancers there are: ");
            double numberDancers = double.Parse(Console.ReadLine());

            Console.Write("Please enter how many days the dancers have: ");
            double numberDays = double.Parse(Console.ReadLine());

            double stepsPerDay = Math.Ceiling(1 * 100 / numberDays);
            double stepPercentagePerDancer = stepsPerDay / numberDancers;

            if (stepsPerDay <= 13)
            {
                Console.WriteLine("Yes, they will succeed in that goal! {0:F2}%.", stepPercentagePerDancer);
            }
            else
            {
                Console.WriteLine("No, They will not succeed in that goal! Required {0:F2}% steps to be learned per day.", stepPercentagePerDancer);
            }
        }
    }
}
