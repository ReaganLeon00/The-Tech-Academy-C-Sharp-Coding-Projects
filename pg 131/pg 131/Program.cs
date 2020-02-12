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

            StringBuilder builder = new StringBuilder("Paragraph");
            builder.Append(", This paragraph is about me ");
            builder.Append("My name is reagan.");
            builder.Append("I am 19 years old.");
            builder.Append("I am a student at the Tech Academy");
            builder.Append("I am currently learning to code.");
            builder.Append("I am doing this assignment for my school");
            Console.WriteLine(builder);

            Console.ReadLine();
        }
    }
}
