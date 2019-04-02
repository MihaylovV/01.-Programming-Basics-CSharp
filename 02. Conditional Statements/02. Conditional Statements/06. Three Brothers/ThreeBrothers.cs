using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Three_Brothers
{
    class ThreeBrothers
    {
        static void Main()
        {
            Console.WriteLine("This will calculate if three brothers will have enough time to clean the garage, while their father is out fishing.");
            Console.WriteLine();

            Console.Write("Please enter how much time brother 1 cleans: ");
            double timeA = double.Parse(Console.ReadLine());

            Console.Write("Please enter how much time brother 2 cleans: ");
            double timeB = double.Parse(Console.ReadLine());

            Console.Write("Please enter how much time brother 3 cleans: ");
            double timeC = double.Parse(Console.ReadLine());

            Console.Write("Please enter how much time the father will be fishing: ");
            double timeD = double.Parse(Console.ReadLine());

            double totalTimeBrothers = 1 / (1 / timeA + 1 / timeB + 1 / timeC);

            double totalTimeWithBrake = totalTimeBrothers + (totalTimeBrothers * 0.15);

            double timeLeft = timeD - totalTimeWithBrake;

            Console.WriteLine("Cleaning time: {0:F2}", totalTimeWithBrake);

            if (timeLeft > 0)
            {
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", Math.Floor(timeLeft));
            }
            else
            {
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", Math.Abs(Math.Floor(timeLeft)));
            }
        }
    }
}
