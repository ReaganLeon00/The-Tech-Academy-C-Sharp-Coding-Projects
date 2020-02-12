using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg131
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This assignment " +
                          "is " +
                          " on page 131.";

            Console.WriteLine(text);
            Console.ReadLine();

            string upperCase = "Uppercase string";
            string upperCase1 = upperCase.ToUpper();
            Console.WriteLine(upperCase1);
            Console.ReadLine();

            System.Text.StringBuilder builder = new System.Text.StringBuilder("Names");
            builder.Append(", ");
            builder.Append("Sarah");
            builder.Append(", Phil");
            builder.Insert(0, "Tara, ");
            builder.Insert(10, 900);
            builder.Append(", ");
            Console.WriteLine(builder);

            Console.ReadLine();
        }
    }
}
