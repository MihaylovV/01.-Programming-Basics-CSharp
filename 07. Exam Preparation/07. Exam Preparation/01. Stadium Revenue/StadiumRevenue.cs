using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Stadium_Revenue
{
    class StadiumRevenue
    {
        static void Main()
        {
            double numberOfSectors = double.Parse(Console.ReadLine());
            double stadiumCapacity = double.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            double totalRevenue = stadiumCapacity * ticketPrice;
            double sectorRevenue = totalRevenue / numberOfSectors;
            double charityRevenue = (totalRevenue - (sectorRevenue * 0.75)) / 8;

            Console.WriteLine("Total income - {0:F2} BGN", totalRevenue);
            Console.WriteLine("Money for charity - {0:F2} BGN", charityRevenue);
        }
    }
}
