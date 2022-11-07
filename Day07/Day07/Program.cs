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
            gObject = new GameObject(5, 10, ConsoleColor.DarkCyan);
            gObject.Draw();

            GameObject player = new GameObject(15, 15, ConsoleColor.Red);
            player.Draw();

            GameObject.DebugIt();

            gObject.X = 10;//calls the set
            int xPosition = gObject.X;//calls the get
        }
    }
}
