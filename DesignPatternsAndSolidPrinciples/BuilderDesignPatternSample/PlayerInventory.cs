using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPatternSample
{
    public class PlayerInventory
    {
        public List<object> _inventories = new List<object>();

        public void Add(string inventory)
        {
            this._inventories.Add(inventory);
        }

        public string CollectInventories()
        {
            string inventories = string.Empty;

            foreach (var inventory in this._inventories)
            {
                inventories += inventory + ", ";
            }

            inventories = inventories.Substring(0, inventories.Length - 2);

            return inventories;
        }
    }
}
