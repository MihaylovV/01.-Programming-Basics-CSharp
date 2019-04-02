using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Alcohol_Market
{
    class AlcoholMarket
    {
        static void Main()
        {
            Console.WriteLine("This will calculate how much $ Pesho will need to buy booze.");
            Console.WriteLine();

            Console.Write("What's the price for a bottle of Whiskey: ");
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double rakiqPrice = whiskeyPrice / 2;
            double winePrice = rakiqPrice - (0.4 * rakiqPrice);
            double beerPrice = rakiqPrice - (0.8 * rakiqPrice);

            Console.Write("How many liters of beer will Pesho buy: ");
            double beerLiters = double.Parse(Console.ReadLine());

            Console.Write("How many liters of wine will Pesho buy: ");
            double wineLiters = double.Parse(Console.ReadLine());

            Console.Write("How many liters of rakiq will Pesho buy: ");
            double rakiqLiters = double.Parse(Console.ReadLine());

            Console.Write("How many liters of whiskey will Pesho buy: ");
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double totalMoneyNeeded = (whiskeyPrice * whiskeyLiters) + (rakiqPrice * rakiqLiters) + (winePrice * wineLiters) + (beerPrice * beerLiters);
            Console.WriteLine("Pesho will need {0:F2} lv to get drunk.", totalMoneyNeeded);
        }
    }
}
