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

        public void PrintInventory()
        {
            Console.WriteLine("------INVENTORY------");
            for (int i = 0; i < Items.Count; i++)
            {
                FantasyWeapon fw = Items[i];
                Console.WriteLine($"Level {fw.Level} {fw.Rarity} weapon that can do {fw.MaxDamage:N0} damage and costs {fw.Costs:C0}");
                //downcast to see if it's a bowweapon
                if(fw is BowWeapon bow)
                    Console.WriteLine($"\tIt's also a bow with {bow.ArrowCount} of {bow.ArrowCapacity} arrows.");
            }
        }
    }
}
