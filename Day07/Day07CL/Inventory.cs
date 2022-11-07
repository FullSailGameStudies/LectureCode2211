using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        private int _capacity = 0;
        private List<string> _items = new List<string>();

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if(value > 0)
                    _capacity = value;
            }
        }
        public int Count
        {
            get { return _items.Count; }
        }
        public List<string> Items
        {
            get { return _items; }
            private set { _items = value; }
        }

        public Inventory(int capacity, List<string> items)
        {
            Capacity = capacity;
            Items = items.ToList();//clone it
        }

        public void AddItem(string itemToAdd)
        {
            if (Count == Capacity)
                throw new Exception("The backpack is full, FOOL!");

            _items.Add(itemToAdd);
        }
    }
}
