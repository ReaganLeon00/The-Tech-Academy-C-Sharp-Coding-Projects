using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_176
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();


            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();

            Console.ReadLine();
        }
    }
}
