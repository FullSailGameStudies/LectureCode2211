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
        private List<FantasyWeapon> _weapons = new List<FantasyWeapon>();

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
            get { return _weapons.Count; }
        }
        public List<FantasyWeapon> Items
        {
            get { return _weapons; }
            private set { _weapons = value; }
        }

        public Inventory(int capacity, List<FantasyWeapon> items)
        {
            Capacity = capacity;
            Items = items.ToList();//clone it
        }

        public void AddItem(FantasyWeapon itemToAdd)
        {
            if (Count == Capacity)
                throw new Exception("The backpack is full, FOOL!");

            _weapons.Add(itemToAdd);
        }
    }
}
