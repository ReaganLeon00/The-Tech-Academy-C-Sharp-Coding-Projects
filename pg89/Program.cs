using System;

namespace pg89
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to multiply by 50.");
            string number1 = Console.ReadLine();
            int num1 = Convert.ToInt32(number1);
            int total1 = num1 * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + total1);

            Console.WriteLine("Enter a number to add to 25.");
            string number2 = Console.ReadLine();
            int num2 = Convert.ToInt32(number2);
            int total2 = num2 + 25;
            Console.WriteLine("Your number added to 25 is: " + total2);

            Console.WriteLine("Enter a number to divide by 12.5.");
            string number3 = Console.ReadLine();
            int num3 = Convert.ToInt32(number3);
            double total3 = num3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + total3);

            Console.WriteLine("Enter a number to see if it is greater than 50.");
            string number4 = Console.ReadLine();
            int num4 = Convert.ToInt32(number4);
            bool trueOrFalse = num4 > 50;
            Console.WriteLine(trueOrFalse);

            Console.WriteLine("Enter a number to divide by 7.");
            string number5 = Console.ReadLine();
            int num5 = Convert.ToInt32(number5);
            int remainder = num5 % 7;
            Console.WriteLine("Your number divided by 7 is: " + remainder);
            Console.ReadLine();

        }
    }
}
