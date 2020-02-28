using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_197
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 5;
            Console.WriteLine(num.Amount);
            Console.ReadLine();

        }
    struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
