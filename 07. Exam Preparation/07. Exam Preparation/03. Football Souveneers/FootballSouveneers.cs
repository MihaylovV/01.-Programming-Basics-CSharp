using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Football_Souveneers
{
    class FootballSouveneers
    {
        static void Main()
        {
            string countryName = Console.ReadLine();
            string souveneerType = Console.ReadLine();
            double numberOfSouveneersBought = double.Parse(Console.ReadLine());

            double total = 0;
            bool isInvalid = false;

            if (countryName == "Argentina" || countryName == "Brazil" || countryName == "Croatia" || countryName == "Denmark")
            {
                isInvalid = false;

                if (countryName == "Argentina")
                {
                    if (souveneerType == "flags")
                    {
                        total = numberOfSouveneersBought * 3.25;
                    }
                    else if (souveneerType == "caps")
                    {
                        total = numberOfSouveneersBought * 7.20;
                    }
                    else if (souveneerType == "posters")
                    {
                        total = numberOfSouveneersBought * 5.10;
                    }
                    else if (souveneerType == "stickers")
                    {
                        total = numberOfSouveneersBought * 1.25;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        isInvalid = true;
                    }
                }

                if (countryName == "Brazil")
                {
                    if (souveneerType == "flags")
                    {
                        total = numberOfSouveneersBought * 4.20;
                    }
                    else if (souveneerType == "caps")
                    {
                        total = numberOfSouveneersBought * 8.50;
                    }
                    else if (souveneerType == "posters")
                    {
                        total = numberOfSouveneersBought * 5.35;
                    }
                    else if (souveneerType == "stickers")
                    {
                        total = numberOfSouveneersBought * 1.20;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        isInvalid = true;
                    }
                }

                if (countryName == "Croatia")
                {
                    if (souveneerType == "flags")
                    {
                        total = numberOfSouveneersBought * 2.75;
                    }
                    else if (souveneerType == "caps")
                    {
                        total = numberOfSouveneersBought * 6.90;
                    }
                    else if (souveneerType == "posters")
                    {
                        total = numberOfSouveneersBought * 4.95;
                    }
                    else if (souveneerType == "stickers")
                    {
                        total = numberOfSouveneersBought * 1.10;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        isInvalid = true;
                    }
                }

                if (countryName == "Denmark")
                {
                    if (souveneerType == "flags")
                    {
                        total = numberOfSouveneersBought * 3.10;
                    }
                    else if (souveneerType == "caps")
                    {
                        total = numberOfSouveneersBought * 6.50;
                    }
                    else if (souveneerType == "posters")
                    {
                        total = numberOfSouveneersBought * 4.80;
                    }
                    else if (souveneerType == "stickers")
                    {
                        total = numberOfSouveneersBought * 0.90;
                    }
                    else
                    {
                        Console.WriteLine("Invalid stock!");
                        isInvalid = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
                isInvalid = true;
            }

            if (isInvalid == false)
            {
                Console.WriteLine("Pepi bought {0} {1} of {2} for {3:F2} lv.", numberOfSouveneersBought, souveneerType, countryName, total);
            }
        }
    }
}
