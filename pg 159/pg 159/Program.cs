using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg159
{
    class Program
    {
        static void Main(string[] args)
        {
            Integer a = new Integer();

            Console.WriteLine("Please type in a number to divide by 15: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int result1 = a.doMathMethod(x);
            Console.WriteLine("Your number divided by 15 is: " + result1);
            Console.ReadLine();


            Console.WriteLine("Please type in a decimal to add to 8: ");
            decimal y = Convert.ToDecimal(Console.ReadLine());
            int result2 = a.doMathMethod(y);
            Console.WriteLine("Your decimal number added to 8 is: " + result2);
            Console.ReadLine();

            Console.WriteLine("12 + 10 is equal to:");
            int z = a.doMathMethod("12");
            Console.WriteLine(z);
            Console.ReadLine();

        }
    }
}
