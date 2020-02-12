using System;

namespace pg123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            
            else if (packageWeight < 50) 
            {
                Console.WriteLine("Please enter the package width:");
                int packageWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package height:");
                int packageHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter package length:");
                int packageLength = Convert.ToInt32(Console.ReadLine());

                int packageDimensions = (packageLength + 2*packageWidth + 2*packageHeight);

                if (packageDimensions > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }

                else if (packageDimensions < 50) 
                {
                    int packagePrice = (packageDimensions * packageWeight / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + packagePrice);
                    Console.WriteLine("Thank you.");
                    Console.ReadLine();
                }
            }


        }
    }
}
