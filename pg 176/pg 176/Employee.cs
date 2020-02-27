using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_176
{
    class Employee : Person
    {
        public override void SayName()
        {
            string fullname = firstName + lastName;
            Console.WriteLine("Name: " + fullname);
        }
        
    }
}
