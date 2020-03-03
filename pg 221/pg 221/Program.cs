using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_221
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Current Date and Time is : " + now);
            Console.WriteLine("Please enter a number:");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It will be " + now.AddHours(input) + " in " + input + " hours ");
            Console.ReadLine();

        }
    }
}
