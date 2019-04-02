using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Beer_And_Chips
{
    class BeerAndChips
    {
        static void Main()
        {
            string nameOfFan = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            double numberOfBeers = double.Parse(Console.ReadLine());
            double numberOfChips = double.Parse(Console.ReadLine());

            double totalPriceBeer = numberOfBeers * 1.20;
            double totalPriceChips = (totalPriceBeer * 0.45) * numberOfChips;
            double totalPriceAll = totalPriceBeer + Math.Ceiling(totalPriceChips);

            if (budget >= totalPriceAll)
            {
                Console.WriteLine("{0} bought a snack and has {1:F2} leva left.", nameOfFan, budget - totalPriceAll);
            }
            else
            {
                Console.WriteLine("{0} needs {1:F2} more leva!", nameOfFan, totalPriceAll - budget);
            }
        }
    }
}
