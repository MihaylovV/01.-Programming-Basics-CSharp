using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Volleyball
{
    class Volleyball
    {
        static void Main()
        {
            Console.Write("Please enter type of year: ");
            string typeOfYear = Console.ReadLine();

            Console.Write("Please enter number of hollydays in a year: ");
            double p = double.Parse(Console.ReadLine());

            Console.Write("Please enter the number of weekends he goes home: ");
            double h = double.Parse(Console.ReadLine());

            double numberOfWeekends = 48;
            double numberOfGamesSofia = (numberOfWeekends - h) * (3.0 / 4);
            double numberOfGamesHometown = h;
            double numberOfGamesHolidays = p * (2.0 / 3);
            double totalGames = numberOfGamesSofia + numberOfGamesHometown + numberOfGamesHolidays;

            if (typeOfYear == "leap")
            {
                totalGames += totalGames * 0.15;
                Console.WriteLine(Math.Truncate(totalGames));
            }
            else
            {
                Console.WriteLine(Math.Truncate(totalGames));
            }

        }
    }
}
