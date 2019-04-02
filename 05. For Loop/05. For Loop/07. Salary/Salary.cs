using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Salary
{
    class Salary
    {
        static void Main()
        {
            double numberOfTabs = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double facebookFine = 150.00;
            double instagramFine = 100.00;
            double redditFine = 50.00;

            for (int i = 0; i < numberOfTabs; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    salary -= facebookFine;
                }
                else if (website == "Instagram")
                {
                    salary -= instagramFine;
                }
                else if (website == "Reddit")
                {
                    salary -= redditFine;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine("{0:F0}", salary);
            }
        }
    }
}
