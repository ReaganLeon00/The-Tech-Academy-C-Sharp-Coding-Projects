using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_156
{
    class Program
    {
        static void Main(string[] args)
        {
            pg_156.threeClass a = new pg_156.threeClass();
            Console.WriteLine("Please select a number to perform 3 basic math operations on: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number multiplied by 3 is equal to: " + a.multiplybyThree(x));
            Console.WriteLine("5 subtracted from your number is equal to: " + a.subtractFive(x));
            Console.WriteLine("Your number plus 7 is equal to: " + a.addSeven(x));
            Console.ReadLine();



        }
    }
}