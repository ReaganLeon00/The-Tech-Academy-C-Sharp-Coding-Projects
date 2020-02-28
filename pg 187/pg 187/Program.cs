using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_187
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> things = new Employee<string>(){ Things = new List<string> {"Effy","Freddie", "Cook", "Katie" } };
            Employee<int> things2 = new Employee<int>() { Things = new List<int> { 1, 2, 3, 4 } };
            
            foreach (string var in things.Things)
            {
                Console.WriteLine(var);
            }

            foreach (int items in things2.Things)
            {
                Console.WriteLine(items);
            }
            Console.ReadLine();
        }
    }
}
