using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exam_Time
{
    class ExamTime
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arivedHour = int.Parse(Console.ReadLine());
            int arivedMinutes = int.Parse(Console.ReadLine());

            DateTime exam = new DateTime(2016, 1, 1, examHour, examMinutes, 1);
            DateTime arive = new DateTime(2016, 1, 1, arivedHour, arivedMinutes, 1);
            TimeSpan diff = exam.Subtract(arive);

            int hourDiff = diff.Hours;
            int minutesDiff = diff.Minutes;

            string[] time = { "Late", "On time", "Early" };
            string timeToExam = String.Empty;

            if (hourDiff < 0 || minutesDiff < 0)
            {
                timeToExam = time[0];

                if (hourDiff < 0)
                {
                    Console.WriteLine(timeToExam);

                    if (Math.Abs(minutesDiff).ToString().Length == 1)
                    {
                        Console.WriteLine("{0}:0{1} hours after the start", Math.Abs(hourDiff), Math.Abs(minutesDiff));
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1} hours after the start", Math.Abs(hourDiff), Math.Abs(minutesDiff));
                    }
                }
                else if (hourDiff == 0)
                {
                    Console.WriteLine(timeToExam);
                    Console.WriteLine("{0} minutes after the start", Math.Abs(minutesDiff));
                }
            }
            else
            {
                if (hourDiff == 0 && minutesDiff <= 30)
                {
                    timeToExam = time[1];

                    if (minutesDiff == 0)
                    {
                        Console.WriteLine(timeToExam);
                    }
                    else
                    {
                        Console.WriteLine(timeToExam);
                        Console.WriteLine("{0} minutes before the start", Math.Abs(minutesDiff));
                    }
                }
                else if (hourDiff >= 0 || minutesDiff > 30)
                {
                    timeToExam = time[2];

                    if (hourDiff == 0)
                    {
                        Console.WriteLine(timeToExam);
                        Console.WriteLine("{0} minutes before the start", Math.Abs(minutesDiff));
                    }
                    else if (hourDiff > 0)
                    {
                        Console.WriteLine(timeToExam);

                        if (minutesDiff.ToString().Length == 1)
                        {
                            Console.WriteLine("{0}:{1}0 hours before the start", Math.Abs(hourDiff), Math.Abs(minutesDiff));
                        }
                        else
                        {
                            Console.WriteLine("{0}:{1} hours before the start", Math.Abs(hourDiff), Math.Abs(minutesDiff));
                        }
                    }
                }
            }
        }
    }
}
