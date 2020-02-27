using System;


namespace pg_164
{
    class Program
    {
         static void Main(string[] args)
        {
            voidClass a = new voidClass();
            Console.WriteLine("Please slect a number to divide by 2: ");
            int x = Convert.ToInt32(Console.ReadLine());
            a.voidMethod(x);

            Output z = new Output();
            z.outputMethod();
            Output.Addition(out int i);
            
            Overload y = new Overload();
            int sum1 = y.Add(1, 2);
            Console.WriteLine("sum of the two "
                              + "integer value : " + sum1);

            int sum2 = y.Add(1, 2, 3);
            Console.WriteLine("sum of the three "
                              + "integer value : " + sum2);

            Console.ReadLine();

        }
    }
}
