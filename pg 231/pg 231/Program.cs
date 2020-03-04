using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pg_231
{
    class Program
    {
        private string hello;

        static void Main(string[] args)
        {
            const string hello = "Hello";
            string var = "Hey";
           
        }
        public Program(string hello, string var) : this(hello)
        {
  
            var = hello;
        }

        public Program(string hello)
        {
            this.hello = hello;
        }
        

    }
  
}
