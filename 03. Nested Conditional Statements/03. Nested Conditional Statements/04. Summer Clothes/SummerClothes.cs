using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Summer_Clothes
{
    class SummerClothes
    {
        static void Main()
        {
            Console.WriteLine("This will read degrees in celcius and time of day (Morning, Afternoon, Evening), and will print which clothes you should pick.");
            Console.WriteLine();

            Console.Write("Please enter temperature (10-42 degrees): ");
            double temperature = double.Parse(Console.ReadLine());

            Console.Write("Please enter time of day (Morning, Afternoon, Evening): ");
            string timeOfDay = Console.ReadLine();

            string outfit;
            string shoes;

            if (temperature >= 10 && temperature <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
            }
            else if (temperature > 18 && temperature <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
            }
            else if (temperature >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
                else if (timeOfDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
                else if (timeOfDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine("Its {0} degrees, get your {1} and {2}", temperature, outfit, shoes);
                }
            }
        }
    }
}
