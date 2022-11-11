using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class GameObject
    {
        #region Access Modifiers
        //3 access modifiers:
        //public: EVERYONE can see it
        //private (default): ONLY THIS CLASS can see it
        //protected: this class and all my descendents 
        #endregion

        #region Fields
        //instance fields
        private int _x, _y;

        static int _numberOfGameObjects = 0;
        #endregion
        #region Properties

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
        #endregion

        #region Constructors (ctor)
        //if you don't make one, the compiler will give you a default ctor
        //if you do, the compiler ctor is NOT provided

        //public GameObject()//default ctor: no parameters
        //{

        //}
        public GameObject(int x, int y, ConsoleColor color)
        {
            Console.WriteLine("GameObject ctor");
            //x = X;//WRONG! backwards!!
            X = x;
            Y = y;
            Color = color;
        }

        #endregion

        //static methods DO NOT have a hidden parameter called 'this'
        public static void DebugIt()
        {
            //Console.SetCursorPosition(this.X, Y);
        }

        //instance methods have a hidden parameter called 'this'
        //'this' is the object the method was called on
        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.BackgroundColor = Color;
            Console.Write(' ');
            Console.ResetColor();
        }

        public virtual void Update()
        {
            //do nothing. base game objects don't move
        }
    }
}
