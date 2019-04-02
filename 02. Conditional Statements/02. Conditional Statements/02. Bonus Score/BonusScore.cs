using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class BonusScore
    {
        static void Main()
        {
            Console.WriteLine("This will calculate bonus score points, based on user inputted score points.");
            Console.WriteLine("If the number is <= to 100 - 5 bonus points.");
            Console.WriteLine("If the number is > than 100 - 20% bonus points.");
            Console.WriteLine("If the number is > than 1000 - 10% bonus points.");
            Console.WriteLine("Extra bonus points if the number is even - +1 bonus point.");
            Console.WriteLine("Extra bonus points if the number ends with 5 - +5 points.");
            Console.WriteLine();

            Console.Write("Please enter score: ");
            double score = double.Parse(Console.ReadLine());
            double bonus = 0;

            if (score <= 100)
            {
                bonus = 5;
            }
            if (score > 100 && score < 1000)
            {
                bonus = score * 0.20;
            }
            if (score > 1000)
            {
                bonus = score * 0.10;
            }

            if (score % 2 == 0)
            {
                bonus += 1;
            }
            else if (score % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine("Bonus Score - {0}", bonus);
            Console.WriteLine("Total Score - {0}", score + bonus);
        }
    }
}
