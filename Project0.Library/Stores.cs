using System;
using System.Collections.Generic;

namespace Project0.Library
{
    public class Stores
    {
        
        public Stores(string name, int id, string location)
        {
            StoreName = name;
            StoreId = id;
            Location = location;
            
        }

        public string StoreName
        { get; private set; }
        public int StoreId
        { get; private set; }
        public string Location
        { get; private set; }

        public string ViewStore()
        {
            string store = $"Name: {StoreName},\nId: {StoreId},\nLocation: {Location}";

            return store;
        }

    }
}
