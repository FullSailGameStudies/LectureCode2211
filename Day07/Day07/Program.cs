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
            gObject = new GameObject();

            gObject.X = 10;//calls the set
            int xPosition = gObject.X;//calls the get
        }
    }
}
