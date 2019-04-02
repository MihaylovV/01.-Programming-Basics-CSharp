using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Point_In_Rectangle
{
    class PointInRectangle
    {
        static void Main()
        {
            Console.WriteLine("This will take x1, y1, x2, y2, x, y from the user, and will print whether the points x and y are inside the rectangle.");
            Console.WriteLine("It should be guaranteed that: x1 < x2 and y1 < y2.");
            Console.WriteLine();

            Console.Write("Please enter value for x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter value for y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter value for x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter value for y2: ");
            double y2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter value for x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Please enter value for y: ");
            double y = double.Parse(Console.ReadLine());

            if (x == x1 || x == x2)
            {
                if (y >= y1 && y <= y2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else if (y == y1 || y == y2)
            {
                if (x >= x1 && x <= x2)
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
