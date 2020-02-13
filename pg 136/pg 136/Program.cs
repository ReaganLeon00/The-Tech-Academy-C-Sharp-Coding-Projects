using System;
using System.Collections.Generic;

namespace pg_136
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("How are you?");
            intList.Add("Sarah");
            intList.Add("Kyle");

            int[] numArray = new int[]{ 7, 14, 21, 28, 35 };
            string[] str1;
            str1 = new string[]{ "purple", "blue", "green", "yellow" };

            bool Keeplooping = true;
            while (Keeplooping == true) 
                {
                Console.WriteLine("Please choose an index number between 0-4");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    Console.WriteLine("You got: " + numArray[input]);
                
                }
                catch
                {
                    Console.WriteLine("Please selecct a valid index");
                }

                    Console.WriteLine("Please choose an index number bewteen 0-3");
                try
                {
                    int input2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("You got: " + str1[input2]);
                   
                }
                catch
                {
                    Console.WriteLine("Please selecct a valid index");
                }

                
                    Console.WriteLine("Please choose an index number bewteen 0-3");
                try
                {
                    int input3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("You got: " + intList[input3]);
                    
                }
                catch
                {
                    Console.WriteLine("Please selecct a valid index");
                }
                Keeplooping = false;
            }
            
            Console.ReadLine();

        }
    }
}
