using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Customers
    {
        //public List<Orders> OrderHistory;
        public Customers(string name, int id)
        {
            CustomerName = name;
            CustomerId = id;
            //Phone = phone;
            CustomerId++;
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
