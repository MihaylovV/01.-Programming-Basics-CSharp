using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Charity_Campaign
{
    class CharityCampaign
    {
        static void Main()
        {
            Console.WriteLine("This will calculate how much money is left after a charity campaign.");
            Console.WriteLine();

            double tortaPrice = 45.00;
            double gofretaPrice = 5.80;
            double palachinkaPrice = 3.20;

            Console.Write("How many days will the campaign be: ");
            int daysCampaign = int.Parse(Console.ReadLine());

            Console.Write("How many cooks will we have: ");
            int numberOfCooks = int.Parse(Console.ReadLine());

            Console.Write("How many torti will a cook make in a day: ");
            int numberTorti = int.Parse(Console.ReadLine());

            Console.Write("How many gofreta will a cook make in a day: ");
            int numberGofreta = int.Parse(Console.ReadLine());

            Console.Write("How many palachinki will a cook make in a day: ");
            int numberPalachinki = int.Parse(Console.ReadLine());

            double cashTorti = numberTorti * tortaPrice;
            double cashGofreta = numberGofreta * gofretaPrice;
            double cashPalachinki = numberPalachinki * palachinkaPrice;

            double totalCashDaily = (cashTorti + cashGofreta + cashPalachinki) * numberOfCooks;
            double totalCashCampaign = totalCashDaily * daysCampaign;
            double totalExpenses = totalCashCampaign / 8;
            double totalCashAfterExpences = totalCashCampaign - totalExpenses;

            Console.WriteLine("Total Cash Earned After Expenses: {0:F2} lv", totalCashAfterExpences);
        }
    }
}
