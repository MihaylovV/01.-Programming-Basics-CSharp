using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.USD_to_BGN
{
    class USDtoBGNconverter
    {
        static void Main()
        {
            Console.WriteLine("This will convert USD values to BGN values. 1.00 USD is 1.79549 BGN.");
            Console.WriteLine();

            Console.Write("Please enter number: ");
            double valueUsd = double.Parse(Console.ReadLine());
            double valueBgn = valueUsd * 1.79549;

            Console.WriteLine("Result: {0:f2}", valueBgn);
        }
    }
}
