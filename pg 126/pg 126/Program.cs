using System;

namespace pg_126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number between 1-5?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 4;

            do
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                        Console.WriteLine("Guess a number between 1-5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("You guessed 2. Try again.");
                        Console.WriteLine("Guess a number between 1-5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                        Console.WriteLine("Guess a number between 1-5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("You guessed the number 4. That is correct!");
                        isGuessed = true;
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                        Console.WriteLine("Guess a number between 1-5?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
            {
                 case 1:
                        Console.WriteLine("You guessed 1. Try again.");
                Console.WriteLine("Guess a number between 1-5?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
                    case 2:
                        Console.WriteLine("You guessed 2. Try again.");
                Console.WriteLine("Guess a number between 1-5?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
                    case 3:
                        Console.WriteLine("You guessed 3. Try again.");
                Console.WriteLine("Guess a number between 1-5?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
                    case 4:
                        Console.WriteLine("You guessed the number 4. That is correct!");
                isGuessed = true;
                Console.ReadLine();
                break;
                    case 5:
                        Console.WriteLine("You guessed 5. Try again.");
                Console.WriteLine("Guess a number between 1-5?");
                number = Convert.ToInt32(Console.ReadLine());
                break;
            }
        }
    }
}
