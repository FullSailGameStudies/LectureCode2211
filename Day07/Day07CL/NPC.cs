using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class NPC : GameObject
    {
        public NPC(Player player,int x, int y, ConsoleColor color) : base(x, y, color)
        {
            PlayerObject = player;
        }

        static Random randy = new Random();
        public override void Update()
        {
            if(randy.Next(100) > 50)
            {
                if (PlayerObject.X < X) X--;
                else X++;
            }
            else
            {
                if (PlayerObject.Y < Y) Y--;
                else Y++;
            }
        }

        public Player PlayerObject { get; private set; }
    }
}
