using Day06;
using Day07CL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (WeaponRarity rarity in Enum.GetValues<WeaponRarity>())
            {
                Console.WriteLine(rarity);
            }
            Console.ReadKey();

            GameObject gObject;//null
            gObject = Factory.BuildGameObject(5, 10, ConsoleColor.DarkCyan);
            gObject.Draw();

            Player player = new Player('$',1, 100, 15, 15, ConsoleColor.Red);
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
            backpack.PrintInventory();
            backpack.PrintList();


            int num = 5;
            long bigNum = num;// implicit casting. compiler can do it.
            num = (int)bigNum;// explicit casting

            //
            // Upcasting
            //      casting from a Derived type variable to a base type variable
            //player variable is a Player object. Player is-a GameObject
            GameObject gameObject = player;
            gameObject = new GameObject(0, 0, ConsoleColor.Black);

            //
            // Downcasting
            //      cast from a BASE type variable to a DERIVED type variable
            //NOT SAFE!!!!
            //ways to downcast...
            //1) explicit cast. MUST USE a try-catch. NOT the best way to downcast
            try
            {
                Player p1 = (Player)gameObject;//gets rid of the build error. will cause an exception
            }
            catch (Exception)
            {
            }
            //2) use the 'as' keyword
            //   will NOT throw an exception.
            //   if gameObject is NOT a player, it will assign NULL to p2
            //   
            Player p2 = gameObject as Player;
            if (p2 != null)
            {
                int x = p2.X; //this could throw a null reference exception
            }
            //3) use pattern matching with the 'is' keyword
            if (gameObject is Player p3)
            {
                int x = p3.X; //this could throw a null reference exception
            }

            Console.WriteLine("Press any key to play...");
            Console.ReadKey();
            Console.Clear();

            List<GameObject> gameObjects = new List<GameObject>();
            gameObjects.Add(player);
            for (int i = 0; i < 20; i++)
            {
                gameObjects.Add(Factory.BuildGameObject(
                    Ext.RandoX(Console.WindowWidth),
                    Ext.RandoY(Console.WindowHeight),
                    Ext.RandoColor()));
            }
            for (int i = 0; i < 5; i++)
            {
                gameObjects.Add(new NPC(player, Ext.RandoX(Console.WindowWidth),
                    Ext.RandoY(Console.WindowHeight),
                    Ext.RandoColor()));
            }
            Console.CursorVisible = false;
            Render(gameObjects);
            //start the game loop
            while (true)
            {
                Update(gameObjects);
                Render(gameObjects);
            }
            Console.CursorVisible = true;
        }

        private static void Render(List<GameObject> gameObjects)
        {
            foreach (GameObject gObject in gameObjects)
            {
                gObject.Draw();
            }
        }

        private static void Update(List<GameObject> gameObjects)
        {
            foreach (var gameObject in gameObjects)
            {
                gameObject.Update();
            }
        }
    }
}
