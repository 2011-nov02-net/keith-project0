using System;
using System.Collections.Generic;

namespace Project0.Library
{
    public class Stores
    {
        public Stores(string name, int id, string location)
        {
            _storeName = name;
            _storeId = id;
            _location = location;
        }

        public string _storeName
        { get; private set; }
        public int _storeId
        { get; private set; }
        public string _location
        { get; private set; }
        

    }
}
