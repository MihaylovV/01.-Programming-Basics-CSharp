using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Rectangle
{
    class RectangleCalculations
    {
        static void Main()
        {
            Console.WriteLine("This will calculate the perimeter and аrea of a rectangle.");
            Console.WriteLine();

            Console.Write("Please enter coordinates for x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter coordinates for y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter coordinates for x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter coordinates for y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);

            double area = width * height;
            double perimeter = 2 * (width + height);

            Console.WriteLine("Area is: {0}", area);
            Console.WriteLine("Perimeter is: {0}", perimeter);
        }
    }
}
