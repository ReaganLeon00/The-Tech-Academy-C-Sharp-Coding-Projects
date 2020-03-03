using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pg_218
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number to add to a file.");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\maggi\source\repos\pg 218\logs.txt",text);

            string text2 = File.ReadAllText(@"C:\Users\maggi\source\repos\pg 218\logs.txt");
            Console.WriteLine("The file reads " + text2);
            Console.ReadLine();
            
        }
    }
}
