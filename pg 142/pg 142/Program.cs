using System;
using System.Collections.Generic;
using System.Threading;

namespace Assignment_pg146
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strArray = { "One ", "Two ", "Three ", "Four " };
            //Console.WriteLine("Please enter some text: ");
            //string insertText = Console.ReadLine();
            //for (int x = 0; x < strArray.Length; x++)
            //{
            //    string s = strArray[x];
            //    Console.WriteLine(s + insertText);
            //}
            //Console.ReadLine();

            //ConsoleKeyInfo cki;

            //do
            //{
            //    Console.WriteLine("looping... press the 'x' key to quit.");


            //    while (Console.KeyAvailable == false)
            //        Thread.Sleep(250);

            //    cki = Console.ReadKey(true);
            //    Console.WriteLine("You pressed the '{0}' key.", cki.Key);
            //} while (cki.Key != ConsoleKey.X);
            //Console.ReadLine();

            //int i = 0;
            //while (i < 2)
            //{
            //    Console.WriteLine("Looping < 2 times");
            //    ++i;
            //}
            
            //Console.ReadLine();



            //int y = 0;
            //while (y <= 3)
            //{
            //    Console.WriteLine("Looping <= 4 times");
            //    ++y;

            //}
            
            //Console.ReadLine();

            //Console.WriteLine("Choose your favorite animal from the list, writing it out exactly as shown.");
            //List<string> listItems = new List<string>() { "Cat", "Dog", "Parrot", "Hamster", "Fish" };
           
            //foreach (string listItem in listItems)
            //{
            //    Console.WriteLine(listItem);
            //}
            
            
            //string userInput = Console.ReadLine();
            //for (int x = 0; x < listItems.Count; x++)
            //{
            //    if (listItems[x] == userInput)
            //    {
            //        Console.WriteLine("The index of your input: " + x);
            //        break;
            //    }

            //    else if (listItems[x] != userInput)
            //        Console.WriteLine("Please type out exactly as printed: ");
            //}
            //Console.ReadLine();


            //List<string> listItems2 = new List<string>() { "Phil", "Carrie", "Sam", "Sarah", "Sarah" };
           
            //foreach (string listItem2 in listItems2)
            //{
            //    Console.WriteLine(listItem2);
            //}
            //Console.ReadLine();
            //Console.WriteLine("Select selct a name from the list and type it exactly as printed:");
            //string userInput2 = Console.ReadLine();
            //for (int z = 0; z < listItems2.Count; z++)
            //{
            //    if (listItems2[z] == userInput2)

            //        Console.WriteLine("The index of your input: " + z);

            //    else if (listItems2[z] != userInput2)
            //        Console.WriteLine("Your input was not found in the list: ");
            //}
            //Console.ReadLine();

            
            List<string> listItems3 = new List<string>() { "Phil", "Carrie", "Sam", "Sarah", "Sarah" };
            List<string> duplicateList = new List<string>();
            for (int t = 0; t < listItems3.Count; t++)
                Console.WriteLine(listItems3[t]);
                //if (duplicateList[t] == "Sarah") 
                //    {
                //    Console.WriteLine("Sarah is a duplicate!");
                //    }
                //else
                //    {
                //    duplicateList.Add(duplicateList[t]);
                //    Console.WriteLine("Sarah isn't a duplicate");
                //    }
           
             

        }
    }
}