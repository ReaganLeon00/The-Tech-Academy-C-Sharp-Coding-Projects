using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_235
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nowDate = DateTime.Now;
            Console.WriteLine("What age are you?");
            while(true)
                {
                try
                {
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age > 0)
                    {
                        Console.WriteLine("You are " + nowDate.AddYears(-age).Year + " years old.");
                        Console.ReadLine();

                    }
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number that is not a zero or a negative!");
                    Console.ReadLine();
                }
                break;
            }
        }
    }
}
