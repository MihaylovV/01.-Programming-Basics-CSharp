using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Traveling
{
    class Traveling
    {
        static void Main()
        {
            Console.Write("Please enter budget: ");
            double budget = double.Parse(Console.ReadLine());

            Console.Write("Which season('summer' or 'winter'): ");
            string season = Console.ReadLine();

            double budgetLeft = 0;

            if (budget <= 100.00)
            {
                Console.WriteLine("Somewhere in Bulgaria");

                if (season == "summer")
                {
                    budgetLeft = budget * 0.30;
                    Console.WriteLine("Camp - {0:F2}", budgetLeft);
                }
                else if (season == "winter")
                {
                    budgetLeft = budget * 0.70;
                    Console.WriteLine("Hotel - {0:F2}", budgetLeft);
                }
            }

            else if (budget > 100.00 && budget <= 1000.00)
            {
                Console.WriteLine("Somewhere in Balkans");

                if (season == "summer")
                {
                    budgetLeft = budget * 0.40;
                    Console.WriteLine("Camp - {0:F2}", budgetLeft);
                }
                else if (season == "winter")
                {
                    budgetLeft = budget * 0.80;
                    Console.WriteLine("Hotel - {0:F2}", budgetLeft);
                }
            }

            else if (budget > 1000.00)
            {
                Console.WriteLine("Somewhere in Europe");
                budgetLeft = budget * 0.90;
                Console.WriteLine("Hotel - {0:F2}", budgetLeft);
            }
        }
    }
}
