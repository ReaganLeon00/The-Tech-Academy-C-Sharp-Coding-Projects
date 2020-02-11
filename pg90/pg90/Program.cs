using System;

namespace pg90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate.");
            string hourlyRate1 = Console.ReadLine();
            int hrRate1 = Convert.ToInt32(hourlyRate1);
            Console.WriteLine("Hours worked per week.");
            string hoursWeekly1 = Console.ReadLine();
            int hrWeek1 = Convert.ToInt32(hoursWeekly1);

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate.");
            string hourlyRate2 = Console.ReadLine();
            int hrRate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Hours worked per week.");
            string hoursWeekly2 = Console.ReadLine();
            int hrWeek2 = Convert.ToInt32(hoursWeekly2);

            Console.WriteLine("Annual salary of person 1:");
            int annual1 = hrRate1 * hrWeek1 * 52;
            Console.WriteLine(annual1);

            Console.WriteLine("Annual salary of person 1:");
            int annual2 = hrRate2 * hrWeek2 * 52;
            Console.WriteLine(annual2);

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = annual1 > annual2;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();
        }
    }
}
