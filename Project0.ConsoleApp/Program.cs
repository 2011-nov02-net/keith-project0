using Project0.Library;
using System;

namespace Project0.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //Customer logic test
            Customers s = new Customers("Jim", 1);
            Console.WriteLine(s.ViewCustomer());

            //Store logic test
            Stores s1 = new Stores("Sears", 101, "Nevada");
            Console.WriteLine(s1.ViewStore());
            
        }
    }
}
