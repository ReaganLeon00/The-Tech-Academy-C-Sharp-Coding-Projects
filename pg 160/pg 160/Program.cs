using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg160
{
    class Program
    {
        static void Main(string[] args)
        {
            newClass a = new newClass();

            Console.WriteLine("Please choose a number. You can type a second number but it is not required.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number(optional): ");
            string y = Console.ReadLine();
            if (y == "")
            {
                int result = a.twoMethod(x);
                Console.WriteLine(result);
                Console.ReadLine();

            }
            else
            {
                int yInt = Convert.ToInt32(y);
                int result = a.twoMethod(x, yInt);
                Console.WriteLine(result);
                Console.ReadLine();

            }




        }
    }
}
