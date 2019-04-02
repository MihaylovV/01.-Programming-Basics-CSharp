using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.World_Swimming_Record
{
    class WorldSwimmingRecord
    {
        static void Main()
        {
            double oldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeMeter = double.Parse(Console.ReadLine());

            double speed = distance * timeMeter;
            double current = (Math.Floor(distance / 15)) * 12.5;
            double totalTime = speed + current;

            if (oldRecord <= totalTime)
            {
                double difference = Math.Abs(oldRecord - totalTime);
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", difference);
            }
            else if (oldRecord > totalTime)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalTime);
            }
        }
    }
}
