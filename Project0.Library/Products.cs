using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    class Products

    {
        public Products(string itemName, double price, string location, int inventory)
        {
            _itemName = itemName;
            _price = price;
            _location = location;
            _inventory = inventory;
        }

        public string _itemName
        { get; private set; }
        public double _price
        { get; private set; }
        public string _location
        { get; private set; }
        public int _inventory
        { get; private set; }
    }
}
