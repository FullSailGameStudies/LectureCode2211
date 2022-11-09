using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Factory
    {
        //everything in a static class MUST BE STATIC
        
        public static GameObject BuildGameObject(int x, int y, ConsoleColor color)
        {
            GameObject gameObject = new GameObject(x,y,color);
            return gameObject;
        }

        public static FantasyWeapon CreateWeapon(WeaponRarity rarity, int level, int maxDamage, int costs)
        {
            return new FantasyWeapon(rarity, level, maxDamage, costs);
        }
    }
}
