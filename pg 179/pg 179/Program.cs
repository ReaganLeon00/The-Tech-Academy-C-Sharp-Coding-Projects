using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_179
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable employee= new Employee();
            employee.Quit();
            Console.ReadLine();
        }
    }
}
