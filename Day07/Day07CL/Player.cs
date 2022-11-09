using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Player : GameObject
    {
        public int Level { get; set; }
        public int Health { get; set; }

        //we need a constructor that will CALL the base constructor
        public Player(int level, int health, int x, int y, ConsoleColor color) : base(x,y,color)
        {
            Console.WriteLine("\tPlayer ctor");
            Level = level;
            Health = health;
            //_x = 0;//why is this a problem?
        }
    }
}
