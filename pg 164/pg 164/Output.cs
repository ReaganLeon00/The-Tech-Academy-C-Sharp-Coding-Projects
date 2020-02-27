using System;
namespace pg_164
{
    class Output
    {
        public void outputMethod()
        {
            int i;
            Addition(out i);
            Console.WriteLine("The addition of the value is: {0}", i);
        }


        public static void Addition(out int i)
        {
            i = 30;
            i += i;
        }

        
    }
}
