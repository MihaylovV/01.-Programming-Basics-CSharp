using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Histogram
{
    class Histogram
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number >= 200 && number < 400)
                {
                    p2++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4++;
                }
                else if (number >= 800)
                {
                    p5++;
                }
            }

            double p1Percent = (p1 / n) * 100;
            double p2Percent = (p2 / n) * 100;
            double p3Percent = (p3 / n) * 100;
            double p4Percent = (p4 / n) * 100;
            double p5Percent = (p5 / n) * 100;

            Console.WriteLine("{0:F2}%", p1Percent);
            Console.WriteLine("{0:F2}%", p2Percent);
            Console.WriteLine("{0:F2}%", p3Percent);
            Console.WriteLine("{0:F2}%", p4Percent);
            Console.WriteLine("{0:F2}%", p5Percent);
        }
    }
}
