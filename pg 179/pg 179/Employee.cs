using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_179
{
    public class Employee : pg_179.IQuittable

    {
        public void Quit()
        {
            Console.Write("I quit");
        }
    }
}
