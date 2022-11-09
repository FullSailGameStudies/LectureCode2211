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

            Player player = new Player(1, 100, 15, 15, ConsoleColor.Red);
            player.Draw();

            GameObject.DebugIt();

            gObject.X = 10;//calls the set
            int xPosition = gObject.X;//calls the get

            Inventory backpack = new Inventory(3, new List<FantasyWeapon>() );
            //backpack.AddItem("sword");
            //backpack.AddItem("map");
            //backpack.AddItem("pipe bomb");
            //try
            //{
            //    backpack.AddItem("Boots");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            FantasyWeapon sting = Factory.CreateWeapon(WeaponRarity.Legendary, 100, 1000, 1000000);
            int damage = sting.DoDamage();
            Console.WriteLine($"I swing sting and do {damage} damage to the rat.");

            BowWeapon bow = new BowWeapon(10, 5, WeaponRarity.Common, 5, 50, 20);
            backpack.AddItem(sting);
            backpack.AddItem(bow);//upcasts bow to a FantasyWeapon
            //when we upcasted it, did we lose arrowcount/capacity?


            int num = 5;
            long bigNum = num;// implicit casting. compiler can do it.
            num = (int)bigNum;// explicit casting

            //
            // Upcasting
            //      casting from a Derived type variable to a base type variable
            //player variable is a Player object. Player is-a GameObject
            GameObject gameObject = player;
        }
    }
}
