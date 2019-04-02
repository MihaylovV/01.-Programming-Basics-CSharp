using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Hotel_Room
{
    class HotelRoom
    {
        static void Main()
        {
            Console.Write("Please enter month (May, June, July, August, September, October): ");
            string month = Console.ReadLine();

            Console.Write("Please enter number of nights: ");
            double numberOfNights = double.Parse(Console.ReadLine());

            double priceApartment = 0;
            double priceStudio = 0;

            if (month == "May" || month == "October")
            {
                if (numberOfNights > 7 && numberOfNights <= 14)
                {
                    priceStudio = numberOfNights * 50.00;
                    priceStudio -= priceStudio * 0.05;

                    priceApartment = numberOfNights * 65.00;

                    Console.WriteLine("Apartment: {0:F2} lv", priceApartment);
                    Console.WriteLine("Studio: {0:F2} lv", priceStudio);
                }

                else if (numberOfNights > 14)
                {
                    priceStudio = numberOfNights * 50.00;
                    priceStudio -= priceStudio * 0.30;

                    priceApartment = numberOfNights * 65.00;
                    priceApartment -= priceApartment * 0.10;

                    Console.WriteLine("Apartment: {0:F2} lv", priceApartment);
                    Console.WriteLine("Studio: {0:F2} lv", priceStudio);
                }
                else
                {
                    priceStudio = numberOfNights * 50.00;
                    priceApartment = numberOfNights * 65.00;

                    Console.WriteLine("Apartment: {0:F2} lv", priceApartment);
                    Console.WriteLine("Studio: {0:F2} lv", priceStudio);
                }
            }

            else if (month == "June" || month == "September")
            {
                if (numberOfNights > 14)
                {
                    priceStudio = numberOfNights * 75.20;
                    priceStudio -= priceStudio * 0.20;

                    priceApartment = numberOfNights * 68.70;
                    priceApartment -= priceApartment * 0.10;

                    Console.WriteLine("Apartment: {0:F2} lv", priceApartment);
                    Console.WriteLine("Studio: {0:F2} lv", priceStudio);
                }
                else
                {
                    priceStudio = numberOfNights * 75.20;
                    priceApartment = numberOfNights * 68.70;

                    Console.WriteLine("Apartment: {0:F2} lv", priceApartment);
                    Console.WriteLine("Studio: {0:F2} lv", priceStudio);
                }
            }

            else if (month == "July" || month == "August")
            {
                if (numberOfNights > 14)
                {
                    priceStudio = numberOfNights * 76.00;
                    priceApartment = numberOfNights * 77.00;
                    priceApartment -= priceApartment * 0.10;

                    Console.WriteLine("Apartment: {0:F2} lv", priceApartment);
                    Console.WriteLine("Studio: {0:F2} lv", priceStudio);
                }
                else
                {
                    priceStudio = numberOfNights * 76.00;
                    priceApartment = numberOfNights * 77.00;

                    Console.WriteLine("Apartment: {0:F2} lv", priceApartment);
                    Console.WriteLine("Studio: {0:F2} lv", priceStudio);
                }
            }
        }
    }
}
