using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Orders
    {
        
        public int orderId;

        public Orders(int orderId, string location)
        {
            orderId = orderId;
            Location = location;
        }

        public string Location
        { get; set; }

        public void ViewOrder()
        {
        }



        
       
        
    }
}
