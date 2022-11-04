using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    public static class Ext
    {

        static Random rando = new Random();

        public static ConsoleColor RandoColor()
        {
            return (ConsoleColor)rando.Next(16);
        }

        public static int RandoX()
        {
            return rando.Next(Console.WindowWidth - 1);
        }

        public static int RandoY()
        {
            return rando.Next(Console.WindowHeight - 1);
        }
    }
}
