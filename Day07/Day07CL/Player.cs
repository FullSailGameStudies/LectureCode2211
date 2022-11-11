using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Player : GameObject
    {
        private int _oldX, _oldY;
        public int Level { get; set; }
        public int Health { get; set; }
        public char Symbol { get; set; }

        //we need a constructor that will CALL the base constructor
        public Player(char symbol, int level, int health, int x, int y, ConsoleColor color) : base(x,y,color)
        {
            Symbol = symbol;
            //Console.WriteLine("\tPlayer ctor");
            Level = level;
            Health = health;
            //_x = 0;//why is this a problem?
        }

        private void SavePosition()
        {
            _oldX = X;
            _oldY = Y;
        }

        public override void Draw()
        {
            Draw(_oldX, _oldY, ConsoleColor.Black);//erase
            Draw(X, Y, Color);
        }

        private void Draw(int x, int y, ConsoleColor color)
        {
            Console.SetCursorPosition(x,y);
            Console.ForegroundColor = color;
            Console.Write(Symbol);
            Console.ResetColor();
        }

        public override void Update()
        {
            //calling the base means EXTENSION
            //NOT calling the base means FULLY OVERRIDING
            //base.Update();

            var key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;
                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;
                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;
                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;
                default:
                    break;
            }
        }

        private void MoveRight()
        {
            SavePosition();
            if (X < Console.WindowWidth-1)
                X++;
            else
                X = 0;
        }

        private void MoveLeft()
        {
            SavePosition();
            if (X > 0)
                X--;
            else
                X = Console.WindowWidth - 1;
        }


        private void MoveDown()
        {
            SavePosition();
            if (Y < Console.WindowHeight - 1)
                Y++;
            else
                Y = 0;
        }

        private void MoveUp()
        {
            SavePosition();
            if (Y > 0)
                Y--;
            else
                Y = Console.WindowHeight - 1;
        }
    }
}
