using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Simulating_Seconds
{
    class SimulatingSeconds
    {
        static void Main()
        {
            Console.WriteLine("This will sum up 3 runner's times, and will display the result in min:seconds format.");
            Console.WriteLine();

            Console.Write("Please enter value for time \"A\": ");
            int timeA = int.Parse(Console.ReadLine());

            Console.Write("Please enter value for time \"B\": ");
            int timeB = int.Parse(Console.ReadLine());

            Console.Write("Please enter value for time \"C\": ");
            int timeC = int.Parse(Console.ReadLine());

            int totalTime = timeA + timeB + timeC;

            if (totalTime > 0 && totalTime < 60)
            {
                if (totalTime < 10)
                {
                    Console.WriteLine("0:0{0}", totalTime);
                }
                else
                {
                    Console.WriteLine("0:{0}", totalTime);
                }
            }
            if (totalTime > 59 && totalTime < 120)
            {
                if (totalTime - 60 < 10)
                {
                    Console.WriteLine("1:0{0}", totalTime - 60);
                }
                else
                {
                    Console.WriteLine("1:{0}", totalTime - 60);
                }

            }
            if (totalTime > 119 && totalTime < 180)
            {
                if (totalTime - 120 < 10)
                {
                    Console.WriteLine("2:0{0}", totalTime - 120);
                }
                else
                {
                    Console.WriteLine("2:{0}", totalTime - 120);
                }
            }
            if (totalTime < 10)
            {
                Console.WriteLine("0:{0}", totalTime);
            }

            Console.ReadKey();
        }
    }
}
