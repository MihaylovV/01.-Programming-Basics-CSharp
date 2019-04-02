using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cinema
{
    class Cinema
    {
        static void Main()
        {
            Console.WriteLine("This will read from the console, type of projection, number of rows and number of collums. It will calculate revenue from a full hall.");
            Console.WriteLine("Prices: ");
            Console.WriteLine("- Premiere - 12.00 BGN");
            Console.WriteLine("- Normal - 7.50 BGN");
            Console.WriteLine("- Discount - 5.00 BGN");
            Console.WriteLine();

            Console.Write("Please enter type of Projection: ");
            string projectionType = Console.ReadLine();

            Console.Write("Please enter number of rows: ");
            double rows = double.Parse(Console.ReadLine());

            Console.Write("Please enter number of collums: ");
            double collums = double.Parse(Console.ReadLine());

            double totalSeats = rows * collums;
            double totalRevenue = 0;

            if (projectionType == "Premiere")
            {
                totalRevenue = totalSeats * 12.00;
            }
            else if (projectionType == "Normal")
            {
                totalRevenue = totalSeats * 7.50;
            }
            else if (projectionType == "Discount")
            {
                totalRevenue = totalSeats * 5.00;
            }

            Console.WriteLine("{0:F2} leva", totalRevenue);
        }
    }
}
