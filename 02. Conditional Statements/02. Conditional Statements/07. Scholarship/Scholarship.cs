using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Scholarship
{
    class Scholarship
    {
        static void Main()
        {
            Console.WriteLine("This will calculate a student's scholarship based on their grades, minimum wage and family revenue.");
            Console.WriteLine();

            Console.Write("Please enter family's revenue: ");
            double familyRevenue = double.Parse(Console.ReadLine());

            Console.Write("Please enter average grade: ");
            double averageGrade = double.Parse(Console.ReadLine());

            Console.Write("Please enter minimum wage: ");
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarshipAmount = minimumWage * 0.35;
            double excelentResultsScholarship = averageGrade * 25;

            if (familyRevenue < minimumWage && averageGrade > 4.5 && socialScholarshipAmount > excelentResultsScholarship)
            {
                Console.WriteLine("You get a social scholarship {0} BGN", socialScholarshipAmount);
            }
            else if (averageGrade >= 5.5 && excelentResultsScholarship > socialScholarshipAmount)
            {
                Console.WriteLine("You get a scholarship for excellent results {0}", excelentResultsScholarship);
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
