using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Customers
    {
        
        
        

        private static int id = 1;
        public Customers(string name)
        {
            CustomerName = name;
            CustomerId = id;
            //Phone = phone;
            id++;
        }

        public string CustomerName
        { get; private set; }
        public int CustomerId
        { get; private set; }
        public string Phone
        { get; private set; }

        public string ViewCustomer()
        {
            string customer = $"Name: {CustomerName} | Id: {CustomerId}";
            return customer;
        }

        



    }
}
