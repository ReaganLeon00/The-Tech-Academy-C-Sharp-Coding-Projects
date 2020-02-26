using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_pg159
{
    public class Integer
    {
        public int doMathMethod(int x)
        {
            int result = x / 15;
            return result;

        }
        public int doMathMethod(decimal y)
        {
            Console.WriteLine("Please type in a decimal number: ");


            int result2 = Convert.ToInt32(y + 8);
            return result2;

        }
        public int doMathMethod(string z)
        {
            int result3 = Convert.ToInt32(z) + 10;
            return result3;
        }
        
    }
}



