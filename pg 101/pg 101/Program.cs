using System;

namespace pg_101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI?(Please enter true or false)");
            bool hasDui = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            
            bool canInsure = (age >= 15 && hasDui==false && tickets <= 3);

            Console.WriteLine("Qualified?");
            Console.WriteLine(canInsure);
            Console.ReadLine();

        }
    }
}
