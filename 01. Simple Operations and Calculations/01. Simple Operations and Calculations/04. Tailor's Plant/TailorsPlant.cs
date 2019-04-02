using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tailor_s_Plant
{
    class TailorsPlant
    {
        static void Main()
        {
            // Table covers have to be 30sm longer on EACH side - +120.00 sm
            // Table cloths have to be half of the tables lenght
            // m2 of cloth for table covers costs $7.00
            // m2 of cloth for table cloths costs $9.00
            // $1.00 is 1.85BGN


            Console.WriteLine("This will calculate prices for table covers in BGN and USD.");
            Console.WriteLine();

            Console.Write("Please enter number of tables: ");
            int numberOfTables = int.Parse(Console.ReadLine());

            Console.Write("Please enter the lenght of the tables: ");
            double tableWidth = double.Parse(Console.ReadLine());

            Console.Write("Please enter the height of the tables: ");
            double tableHeight = double.Parse(Console.ReadLine());

            double totalTableCover = numberOfTables * (tableWidth + 2 * 0.30) * (tableHeight + 2 * 0.30);
            double totalTableCloth = numberOfTables * (tableWidth / 2) * (tableWidth / 2);

            double priceLevs = (totalTableCover * 7) + (totalTableCloth * 9);
            double priceUsd = priceLevs * 1.85;

            Console.WriteLine("Price in BGN: {0:f2}", priceUsd);
            Console.WriteLine("Price in USD: {0:f2}", priceLevs);
        }
    }
}
