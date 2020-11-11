using Project0.Library;
using System;
using System.Collections.Generic;

namespace Project0.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplication app = new Applications();

            Console.WriteLine("To add a customer press 1: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Please enter customer name: ");
                string name = Console.ReadLine();
                app.AddCustomer(new Customers(name));
            }



            app.AddCustomer(new Customers("Jim"));


            Console.WriteLine();


            //Customer logic test

            //Console.WriteLine(c.ViewCustomer());
            //Console.WriteLine(c1.ViewCustomer());

            //Store logic test
            Stores s1 = new Stores("Sears", 101, "Nevada");
            Console.WriteLine(s1.ViewStore());

            //creating products to gather for stores ??????
            Products p1 = new Products("Toy", false, "Nevada");
            Console.WriteLine(p1.HasProduct());
            //Products p2 = new Products("Game", true, "Texas");
            //Products p3 = new Products("Food", true, "Florida");
            //Products p4 = new Products("Bike", false, "Arizona");
            //Console.WriteLine(p1.ViewProduct());

        }
    }
}
