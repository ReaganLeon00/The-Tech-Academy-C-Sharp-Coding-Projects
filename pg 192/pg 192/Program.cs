using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_192
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a day of the week.");
                string input = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                Console.WriteLine("Thank you for entering a valid day of the week!");
                Console.ReadLine();
            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week");
                Console.ReadLine();
            }
        }
        

    }
}
