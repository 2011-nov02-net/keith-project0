using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Applications : IApplication
    {
        List<Customers> _customers = new List<Customers>();

        public List<Customers> Customer
        {
            get
            {
                return _customers;
            }

            private set
            {
                _customers = value;
            }

        }
         void IApplication.AddCustomer(Customers customer)
        {
            _customers.Add(customer);
        }
        
    }
}
