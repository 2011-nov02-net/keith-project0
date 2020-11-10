using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Products
        
    {
        public Products(string itemName, double price, string location, int inventory)
        {
            ItemName = itemName;
            Price = price;
            Location = location;
            Inventory = inventory;
        }
        
        public string ItemName
        { get; private set; }
        public double Price
        { get; private set; }
        public string Location
        { get; private set; }
        public int Inventory
        { get; private set; }
        
    }
}
