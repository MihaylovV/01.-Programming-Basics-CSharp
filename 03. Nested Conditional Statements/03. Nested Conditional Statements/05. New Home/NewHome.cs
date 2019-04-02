using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.New_Home
{
    class NewHome
    {
        static void Main()
        {
            Console.Write("Roses, Dahlias, Tulips, Narcissus or Gladiolus: ");
            string flowerType = Console.ReadLine();

            Console.Write("Number of Flowers: ");
            double numberOfFlowers = double.Parse(Console.ReadLine());

            Console.Write("Please enter budget: ");
            double budget = double.Parse(Console.ReadLine());

            double cost = 0;

            if (flowerType == "Roses")
            {
                cost = numberOfFlowers * 5.00;

                if (numberOfFlowers > 80)
                {
                    cost -= cost * 0.10;
                }
            }
            else if (flowerType == "Dahlias")
            {
                cost = numberOfFlowers * 3.80;

                if (numberOfFlowers > 90)
                {
                    cost -= cost * 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                cost = numberOfFlowers * 2.80;

                if (numberOfFlowers > 80)
                {
                    cost -= cost * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                cost = numberOfFlowers * 3.00;

                if (numberOfFlowers < 120)
                {
                    cost += cost * 0.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                cost = numberOfFlowers * 2.50;

                if (numberOfFlowers < 80)
                {
                    cost += cost * 0.20;
                }
            }

            double moneyLeft = budget - cost;
            double moneyNeeded = cost - budget;

            if (moneyLeft > 0)
            {
                Console.WriteLine("Hey, you have a great garden with {0} {1} and {2:F2} leva left.", numberOfFlowers, flowerType, moneyLeft);
            }
            else
            {
                Console.WriteLine("Not enough money, you need {0:F2} leva more.", moneyNeeded);
            }

        }
    }
}
