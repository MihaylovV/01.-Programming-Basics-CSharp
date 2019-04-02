using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Currency_Converter
{
    class CurrencyConverter
    {
        static void Main()
        {
            // 1 BGN - 1.79549 USD - 1.95583 EUR - 2.53405 GBR

            Console.WriteLine("This will convert money into different currencies.");
            Console.WriteLine();

            Console.Write("Please enter number: ");
            decimal number = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter currency to be converted, eg. BGN, USD, EUR, GBP: ");
            string firstCurrency = Console.ReadLine();

            Console.Write("Please enter the currency to convert to, eg. BGN, USD, EUR, GBP: ");
            string secondCurrency = Console.ReadLine();

            decimal finalNumber = 0;

            switch (firstCurrency)
            {
                case "BGN":
                    if (secondCurrency == "USD")
                    {
                        finalNumber = number / 1.79549m;
                    }
                    if (secondCurrency == "EUR")
                    {
                        finalNumber = number / 1.95583m;
                    }
                    if (secondCurrency == "GBP")
                    {
                        finalNumber = number / 2.53405m;
                    }
                    break;

                case "USD":
                    if (secondCurrency == "BGN")
                    {
                        finalNumber = number * 1.79549m;
                    }
                    if (secondCurrency == "EUR")
                    {
                        finalNumber = (number * 1.79549m) / 1.95583m;
                    }
                    if (secondCurrency == "GBP")
                    {
                        finalNumber = (number * 1.79549m) / 2.53405m;
                    }
                    break;

                case "EUR":
                    if (secondCurrency == "BGN")
                    {
                        finalNumber = number * 1.95583m;
                    }
                    if (secondCurrency == "USD")
                    {
                        finalNumber = (number * 1.95583m) / 1.79549m;
                    }
                    if (secondCurrency == "GBP")
                    {
                        finalNumber = (number * 1.95583m) / 2.53405m;
                    }
                    break;

                case "GBP":
                    if (secondCurrency == "BGN")
                    {
                        finalNumber = number * 2.53405m;
                    }
                    if (secondCurrency == "USD")
                    {
                        finalNumber = (number * 2.53405m) / 1.79549m;
                    }
                    if (secondCurrency == "EUR")
                    {
                        finalNumber = (number * 2.53405m) / 1.95583m;
                    }
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("{0:F2} {1} is {2:F2} {3}", number, firstCurrency, finalNumber, secondCurrency);
        }
    }
}
