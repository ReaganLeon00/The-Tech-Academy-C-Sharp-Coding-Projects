using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_184
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sarah";
            employee.LastName = "Fall";
            employee.Id = 24;

            Employee employee2 = new Employee();
            employee2.FirstName = "Chris";
            employee2.LastName = "Angel";
            employee.Id = 34;

            Console.ReadLine();
        }
    }
}
