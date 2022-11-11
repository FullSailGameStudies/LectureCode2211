using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class FantasyWeapon
    {
        public WeaponRarity Rarity { get; set; }
        public int Level { get; set; }
        public int MaxDamage { get; set; }
        public int Costs { get; set; }

        public int DoDamage()
        {
            Random randy = new Random();
            return (int)(randy.NextDouble() * MaxDamage);
        }

        public FantasyWeapon(WeaponRarity rarity, int level, int maxDamage, int costs)
        {
            Rarity = rarity;
            Level = level;
            MaxDamage = maxDamage;
            Costs = costs;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Level {Level} {Rarity} weapon that can do {MaxDamage:N0} damage and costs {Costs:C0}");
        }
    }
}
