using System;

namespace Pg72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string helpTorF = Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string feedbackExperience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedbackSpecifics = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudied = Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            
        }
    }
}
