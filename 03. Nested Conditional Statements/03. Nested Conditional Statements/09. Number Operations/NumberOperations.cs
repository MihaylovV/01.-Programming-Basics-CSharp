using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Number_Operations
{
    class NumberOperations
    {
        static void Main()
        {
            Console.Write("Please enter value for N1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Please enter value for N2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write("Please enter operation ('+', '-', '*', '/', '%'): ");
            string operation = Console.ReadLine();

            double result = 0;

            string oddOrEven = "";

            if (operation == "+")
            {
                result = n1 + n2;

                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else if (result % 2 != 0)
                {
                    oddOrEven = "odd";
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operation, n2, result, oddOrEven);
            }

            else if (operation == "-")
            {
                result = n1 - n2;

                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else if (result % 2 != 0)
                {
                    oddOrEven = "odd";
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operation, n2, result, oddOrEven);
            }

            else if (operation == "*")
            {
                result = n1 * n2;

                if (result % 2 == 0)
                {
                    oddOrEven = "even";
                }
                else if (result % 2 != 0)
                {
                    oddOrEven = "odd";
                }

                Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, operation, n2, result, oddOrEven);
            }

            else if (operation == "/")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 / n2;

                    Console.WriteLine("{0} / {1} = {2:F2}", n1, n2, result);
                }
            }

            else if (operation == "%")
            {
                if (n2 == 0)
                {
                    Console.WriteLine("Cannot divide {0} by zero", n1);
                }
                else
                {
                    result = n1 % n2;

                    Console.WriteLine("{0} % {1} = {2}", n1, n2, result);
                }
            }
        }
    }
}
