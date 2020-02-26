using System;
using System.Collections.Generic;

namespace pg_147
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 20, 34, 56, 72 };
            
            bool KeepLooping = true;
            while (KeepLooping == true)
            {
                {
                    Console.WriteLine("Please pick a number to divide each list interger by: ");
                    try
                    {
                        int userInput = Convert.ToInt32(Console.ReadLine());
                        foreach (int i in numbers)
                        {
                            string result = Convert.ToString((i / userInput));
                            Console.WriteLine(i + " divided by " + userInput + " = " + result);
                            

                        }
                        Console.ReadLine();
                        
                    }
                    catch
                    {
                        Console.WriteLine("Please selecct a valid index");
                    }
                    Console.WriteLine("program has emerged from the try/catch block and continued on with program execution");
                    KeepLooping = false;
                    Console.ReadLine();
                }

            }
            
        }
    }
}