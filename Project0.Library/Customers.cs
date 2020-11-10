using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    class Customers
    {
        public Customers(string name, int id, string phone)
        {
            _customerName = name;
            _customerId = id;
            _phone = phone;
        }

        public string _customerName
        { get; private set; }
        public int _customerId
        { get; private set; }
        public string _phone
        { get; private set; }



    }
}
