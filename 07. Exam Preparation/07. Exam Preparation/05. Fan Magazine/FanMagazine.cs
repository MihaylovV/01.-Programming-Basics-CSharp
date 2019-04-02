using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fan_Magazine
{
    class FanMagazine
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            double totalCost = 0;

            for (int i = 0; i < n; i++)
            {
                string item = Console.ReadLine();

                if (item == "hoodie")
                {
                    totalCost += 30.00;
                }

                if (item == "keychain")
                {
                    totalCost += 4.00;
                }

                if (item == "T-shirt")
                {
                    totalCost += 20.00;
                }

                if (item == "flag")
                {
                    totalCost += 15.00;
                }

                if (item == "sticker")
                {
                    totalCost += 1;
                }
            }

            if (budget >= totalCost)
            {
                Console.WriteLine("You bought {0} items and left with {1} lv", n, budget - totalCost);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0} more lv.", totalCost - budget);
            }
        }
    }
}
