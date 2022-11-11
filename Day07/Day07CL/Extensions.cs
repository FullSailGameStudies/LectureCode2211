using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public static class Extensions
    {
        public static void PrintList(this Inventory backpack)
        {
            for (int i = 0; i < backpack.Count; i++)
            {
                FantasyWeapon fw = backpack.Items[i];
                Console.WriteLine($"{i+1}. {fw.Rarity}");
            }
        }

        public static ConsoleColor GetColor(this WeaponRarity rarity)
        {
            ConsoleColor color = ConsoleColor.Gray;
            switch (rarity)
            {
                case WeaponRarity.Uncommon:
                    color = ConsoleColor.Green;
                    break;
                case WeaponRarity.Rare:
                    color = ConsoleColor.Blue;
                    break;
                case WeaponRarity.Legendary:
                    color = ConsoleColor.Magenta;
                    break;
            }
            return color;
        }
    }
}
