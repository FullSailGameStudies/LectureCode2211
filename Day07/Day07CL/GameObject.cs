using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class GameObject
    {
        //3 access modifiers:
        //public: EVERYONE can see it
        //private (default): ONLY THIS CLASS can see it
        //protected: this class and all my descendents

        //instance fields
        private int _x, _y;

        static int _numberOfGameObjects = 0;

        //auto-prop
        //  the compiler will define and use the field
        public ConsoleColor Color { get; private set; }

        //full property
        // we define and use a backing field
        public int X
        {
            //getter (accessor)
            //same as...
            //public int GetX() {return _x;}
            get { return _x; }

            //setter (mutator)
            //same as...
            //public void SetX(int value) {_x = value;}
            set
            {
                if (value >= 0 && value < Console.WindowWidth)
                    _x = value;
            }
        }
        public int Y
        {
            get { return _y; }
            set
            {
                if (value >= 0 && value < Console.WindowHeight) 
                    _y = value; 
            }
        }
    }
}
