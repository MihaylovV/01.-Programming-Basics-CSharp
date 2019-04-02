using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Metric_Converter
{
    class MetricConverter
    {
        static void Main()
        {
            Console.WriteLine("This will convert different values from one metric to another.");
            Console.WriteLine();

            Console.Write("Please enter value: ");
            double value = double.Parse(Console.ReadLine());

            Console.Write("Please enter initial metric: ");
            string initialMetric = Console.ReadLine();

            Console.Write("Please enter final metric: ");
            string finalMetric = Console.ReadLine();

            double result = 0;
            double finalResult = 0;

            // turn every possible input to m for ease.
            if (initialMetric == "mm")
            {
                result = value / 1000;
            }
            else if (initialMetric == "cm")
            {
                result = value * 0.01;
            }
            else if (initialMetric == "mi")
            {
                result = value * 1609.344000614692;
            }
            else if (initialMetric == "in")
            {
                result = value * 0.025400000025908;
            }
            else if (initialMetric == "km")
            {
                result = value * 1000;
            }
            else if (initialMetric == "ft")
            {
                result = value * 0.304799999536704;
            }
            else if (initialMetric == "yd")
            {
                result = value * 0.914399998610112;
            }
            else if (initialMetric == "m")
            {
                result = value;
            }

            // turn from m to desired metric
            if (finalMetric == "m")
            {
                finalResult = result;
            }
            else if (finalMetric == "mm")
            {
                finalResult = result * 1000;
            }
            else if (finalMetric == "cm")
            {
                finalResult = result * 100;
            }
            else if (finalMetric == "mi")
            {
                finalResult = result * 0.000621371192;
            }
            else if (finalMetric == "in")
            {
                finalResult = result * 39.3700787;
            }
            else if (finalMetric == "km")
            {
                finalResult = result * 0.001;
            }
            else if (finalMetric == "ft")
            {
                finalResult = result * 3.2808399;
            }
            else if (finalMetric == "yd")
            {
                finalResult = result * 1.0936133;
            }

            // display result

            Console.WriteLine("{0:F8}", finalResult);
        }
    }
}
