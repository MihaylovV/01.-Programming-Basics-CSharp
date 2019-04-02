using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dance_Studio
{
    class DanceStudio
    {
        static void Main()
        {
            Console.WriteLine("This will calculate how many dancers can fit into a dance studio with user defined size.");
            Console.WriteLine();

            Console.Write("Please enter the Studio's Lenght in Meters: ");
            double studioLenght = double.Parse(Console.ReadLine());

            Console.Write("Please enter the Studio's Height in Meters: ");
            double studioHeight = double.Parse(Console.ReadLine());

            Console.Write("Please enter the lenght of the Wardrobe's side in Meters: ");
            double wardrobeSize = double.Parse(Console.ReadLine());

            double sizeOfStudioInSentimiters = (studioLenght * 100) * (studioHeight * 100);
            double sizeOfWardrobe = (wardrobeSize * 100) * (wardrobeSize * 100);
            double benchSize = sizeOfStudioInSentimiters / 10;
            double freeStudioSpace = sizeOfStudioInSentimiters - sizeOfWardrobe - benchSize;
            int numberOfDancers = (int)freeStudioSpace / (40 + 7000);

            Console.WriteLine("Total Number of Dancers who can be in the studio is: {0}", numberOfDancers);
        }
    }
}
