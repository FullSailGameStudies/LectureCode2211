using Day07CL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject gObject;//null
            gObject = Factory.BuildGameObject(5, 10, ConsoleColor.DarkCyan);
            gObject.Draw();

            GameObject player = Factory.BuildGameObject(15, 15, ConsoleColor.Red);
            player.Draw();

            GameObject.DebugIt();

            gObject.X = 10;//calls the set
            int xPosition = gObject.X;//calls the get

            Inventory backpack = new Inventory(3, new List<string>() );
            backpack.AddItem("sword");
            backpack.AddItem("map");
            backpack.AddItem("pipe bomb");
            try
            {
                backpack.AddItem("Boots");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            FantasyWeapon sting = new FantasyWeapon(WeaponRarity.Legendary, 100, 1000, 1000000);
            int damage = sting.DoDamage();
            Console.WriteLine($"I swing sting and do {damage} damage to the rat.");
        }
    }
}
