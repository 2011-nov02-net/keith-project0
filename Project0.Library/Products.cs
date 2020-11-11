using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Products

    {
        public Products(string itemName, bool inStock, string location)
        {
            ItemName = itemName;
            InStock = inStock;
            Location = location;
        }

        public string ItemName
        { get; private set; }
        public bool InStock
        { get; private set; }
        public string Location
        { get; private set; }
        public int Inventory
        { get; private set; }

        public string HasProduct()
        {
            if (InStock)
            {
                return $"{ItemName} is available at {Location}";
            } else
            {
                return $"{ItemName} unavailable at {Location}";
            }
        }



        

        //List<Products> storeProducts = new List<Products>();

        public string ViewProduct()
        {
            string viewProducts = $"Item: {ItemName},\nLocation: {Location},\nInventory: {Inventory}";
            return viewProducts;
        }

    }
}
