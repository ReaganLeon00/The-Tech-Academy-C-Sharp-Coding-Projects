using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_202
{
    class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>
             {
            new Employee { Id = 1, FirstName = "Effy", LastName = "Stonem"},
            new Employee { Id = 2, FirstName = "Joe", LastName = "Goldberg"},
            new Employee { Id = 3, FirstName = "Joe", LastName = "Philis" },
            new Employee { Id = 4, FirstName = "Tony", LastName = "Stonem" },
            new Employee { Id = 5, FirstName = "Freddie", LastName = "McClair" },
            new Employee { Id = 6, FirstName = "Cassie", LastName = "Ainsworth" },
            new Employee { Id = 7, FirstName = "Chris", LastName = "Miles" },
            new Employee { Id = 8, FirstName = "Sid", LastName = "Jenkins" },
            new Employee { Id = 9, FirstName = "Naomi", LastName = "Campbell" },
            new Employee { Id = 10, FirstName = "JJ", LastName = "Jones" },
            };

            List<Employee> joeList = new List<Employee>();
            foreach (Employee Joe in employees)
            {
                if (Joe.FirstName == "Joe")
                {
                    joeList.Add(Joe);
                }

            }
            foreach (Employee Joe in joeList)
            {
                Console.WriteLine(Joe.FirstName);
            }
            
            Console.ReadLine();

            List<Employee> lambdaJoeList = employees.Where(item => item.FirstName == "Joe").ToList();
            foreach ( Employee item in lambdaJoeList)
            {
                Console.WriteLine(item.FirstName);
            }
            Console.ReadLine();

            List<Employee> lambdaId = employees.Where(x => x.Id > 5).ToList();
            foreach (Employee x in lambdaId)
            {
                Console.WriteLine(x.Id);
            }
            Console.ReadLine();

        }
    
    }
}
