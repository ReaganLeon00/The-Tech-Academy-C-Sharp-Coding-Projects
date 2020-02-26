using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_164
{
    class Program
    {
        static void Main(string[] args)
        {
            voidClass a = new voidClass();
            Console.WriteLine("Please slect a number to divide by 2: ");
            int x = Convert.ToInt32(Console.ReadLine());
            a.voidMethod(x);
            Console.WriteLine("Your number divided by 2: " + a.voidMethod(x));
            Console.ReadLine();

        }
    }
}
