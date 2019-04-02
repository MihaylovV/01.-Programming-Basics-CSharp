using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Best_Player
{
    class BestPlayer
    {
        static void Main()
        {
            bool programEnds = false;
            string bestPlayer = "";
            double mostGoals = 0;

            while (programEnds == false)
            {
                string playerName = Console.ReadLine();

                if (playerName == "END")
                {
                    programEnds = true;
                    break;
                }

                double numberOfGoals = double.Parse(Console.ReadLine());

                if (numberOfGoals >= 10)
                {
                    bestPlayer = playerName;
                    mostGoals = numberOfGoals;
                    programEnds = true;
                    break;
                }

                if (numberOfGoals > mostGoals && numberOfGoals < 10)
                {
                    bestPlayer = playerName;
                    mostGoals = numberOfGoals;
                    programEnds = false;
                }
            }


            Console.WriteLine("{0} is the best player!", bestPlayer);

            if (mostGoals >= 3)
            {
                Console.WriteLine("{0} has scored {1} goals and made a hat-trick !!!", bestPlayer, mostGoals);
            }
            else
            {
                Console.WriteLine("{0} has scored {1} goals.", bestPlayer, mostGoals);
            }
        }
    }
}
