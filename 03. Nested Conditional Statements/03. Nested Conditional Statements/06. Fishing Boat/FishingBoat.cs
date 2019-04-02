using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fishing_Boat
{
    class FishingBoat
    {
        static void Main()
        {
            Console.Write("Please enter the group's budget: ");
            double budget = double.Parse(Console.ReadLine());

            Console.Write("Please enter current season (Spring, Summer, Autumn, Winter): ");
            string season = Console.ReadLine();

            Console.Write("Please enter number of fishermen: ");
            double numberOfFishermen = double.Parse(Console.ReadLine());

            double tripCost = 0;

            if (season == "Spring")
            {
                tripCost = 3000.00;
            }
            else if (season == "Summer")
            {
                tripCost = 4200.00;
            }
            else if (season == "Autumn")
            {
                tripCost = 4200.00;
            }
            else if (season == "Winter")
            {
                tripCost = 2600;
            }

            double discount = 0;

            if (numberOfFishermen <= 6)
            {
                discount = tripCost * 0.10;
                tripCost -= discount;
            }
            else if (numberOfFishermen >= 7 && numberOfFishermen <= 11)
            {
                discount = tripCost * 0.15;
                tripCost -= discount;
            }
            else if (numberOfFishermen >= 12)
            {
                discount = tripCost * 0.25;
                tripCost -= discount;
            }

            if (numberOfFishermen % 2 == 0 && season != "Autumn")
            {
                tripCost = tripCost - (tripCost * 0.5);
            }

            double moneyLeft = budget - tripCost;
            double moneyNeeded = tripCost - budget;

            if (tripCost <= budget)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", moneyLeft);
            }
            else if (tripCost > budget)
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", moneyNeeded);
            }

        }
    }
}
