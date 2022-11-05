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

        public static int RandoX(int upper = 0)
        {
            if (upper == 0)
                upper = Console.WindowWidth - 1;
            return rando.Next(upper);
        }

        public static int RandoY(int upper = 0)
        {
            if (upper == 0)
                upper = Console.WindowHeight - 1;
            return rando.Next(upper);
        }
    }
}
