using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class BowWeapon : FantasyWeapon
    {
        public int ArrowCapacity { get; set; }
        public int ArrowCount { get; set; }

        public BowWeapon(int arrowCapacity, int arrowCount, WeaponRarity rarity, int level, int maxDamage, int costs) :
            base(rarity, level, maxDamage, costs)
        {
            ArrowCapacity = arrowCapacity;
            ArrowCount = arrowCount;
        }
    }
}
