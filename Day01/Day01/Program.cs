using System;

namespace Day01
{

    //Day 01

    //METHODS
    //- call DrawBlock

    //Pass by Value
    //- add DrawBlock overload that takes an x, y, color params
    //- call new DrawBlock method


    //Pass by Ref
    //- GetCursorPosition(ref x, ref y)


    //Out param
    //- GetWindowBounds(out width, out height)


    //optional param
    //- SetColors(foreground, background = black)

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                int part = 1;
                Console.Write("What part to run?\n0. Exit\n1. Part 1 - Calling Methods\n2. Part 2 - Parameters\n3. Part 3 - Ref Parameters\n4. Part 4 - Out Parameters\n5. Extras\nChoice? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out part) && part > 0 && part < 6)
                {
                    switch (part)
                    {
                        case 1:
                            Part1();
                            break;
                        case 2:
                            Part2();
                            break;
                        case 3:
                            Part3();
                            break;
                        case 4:
                            Part4();
                            break;
                        case 5:
                            ExtraChallenges.Run();
                            break;
                        default:
                            break;
                    }
                }
                else
                    break;
            }
            Console.ReadKey();
        }

        #region Symbols
        static char deadPool = '\u0308';
        static char dot = '\u2219';
        static char bigdot = '\u263C';// '\u25CF';// '\u25A0';
        #endregion

        #region Objects
        static GameObject deadpool;
        static GameObject goal;
        static GameObject[] dots;

        private static void InitObjects()
        {
            deadpool = new GameObject() { X = Console.WindowWidth / 2, Y = Console.WindowHeight / 2, Symbol = deadPool, Back = ConsoleColor.Red, Fore = ConsoleColor.White };
            goal = new GameObject() { X = deadpool.X + 6, Y = deadpool.Y, Symbol = bigdot, Back = ConsoleColor.Black, Fore = ConsoleColor.Yellow };
            dots = new GameObject[5];
            for (int i = 0; i < dots.Length; i++)
            {
                dots[i] = new GameObject() { X = deadpool.X + i + 1, Y = deadpool.Y, Fore = ConsoleColor.White, Symbol = dot };
            }
        }
        private static void DrawObjects()
        {
            deadpool.DrawMe();
            goal.DrawMe();
            foreach (var gameObject in dots)
            {
                gameObject.DrawMe();
            }
        }
        #endregion


        #region Part1
        public static void Part1()
        {
            Console.Clear();
            Console.WriteLine("Part 1 -- calling methods");
            Console.WriteLine("Add code to Part 1 to move DeadPool to the prize using the Move methods.");

            InitObjects();
            DrawObjects();

            Console.SetCursorPosition(0, 4);
            Console.WriteLine("Press any key to start your code.");
            Console.ReadKey(true);

            //-------------------------------------------------------------------------------------------
            //
            // Add code to Part 1 to move DeadPool to the prize using the Move methods.
            //
            //-------------------------------------------------------------------------------------------





            //-------------------------------------------------------------------------------------------

            if (deadpool.X == goal.X && deadpool.Y == goal.Y)
                Graphics.ShowResult(true);
            else
                Graphics.ShowResult(false);
            Console.ReadKey(true);
        }

        #endregion

        #region Part2
        public static void Part2()
        {
            Console.Clear();
            Console.WriteLine("Part 2 -- Parameters");
            Console.WriteLine("(1) Write a method to check the position of deadpool to the goal (pass them as parameters to the method). Return true if they match otherwise return false.");
            Console.WriteLine("(2) Use the method in the result printing if block.");

            InitObjects();
            DrawObjects();

            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Press any key to start your code.");
            Console.ReadKey(true);

            //-------------------------------------------------------------------------------------------
            //
            // Add code to Part 2 to move DeadPool to the prize using the Move methods.
            //
            //-------------------------------------------------------------------------------------------





            //-------------------------------------------------------------------------------------------

            if (deadpool.X == goal.X && deadpool.Y == goal.Y)  //-------Call your method here in place of the conditions
                Graphics.ShowResult(true);
            else
                Graphics.ShowResult(false);
            Console.ReadKey(true);
        }
        //-------------------------------------------------------------------------------------------
        //
        // Write a method to check the position of deadpool to the goal (pass them as parameters to the method).
        // Return true if they match otherwise return false.
        //
        //-------------------------------------------------------------------------------------------

        #endregion

        #region Part3
        public static void Part3()
        {
            Console.Clear();
            Console.WriteLine("Part 3 -- Ref Parameters");
            Console.WriteLine("(1) Create a method to use 2 ref parameters: foreground color and background color. Set them to whatever colors you want.");
            Console.WriteLine("(2) Call your method to get the foreground and background colors for initializing the deadpool object.");


            //-------------------------------------------------------------------------------------------
            //
            // Call your method to get the foreground and background colors for initializing the deadpool object
            //
            //-------------------------------------------------------------------------------------------



            //-------------------------------------------------------------------------------------------

            //set Back and Fore to the variables used when calling your method
            GameObject deadpool = new GameObject() { X = Console.WindowWidth / 2, Y = Console.WindowHeight / 2, Symbol = deadPool, Back = ConsoleColor.Red, Fore = ConsoleColor.White };
            deadpool.DrawMe();

            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

        }
        //-------------------------------------------------------------------------------------------
        //
        // Create a method to use 2 ref parameters: foreground color and background color.
        // Set them to whatever colors you want.
        //
        //-------------------------------------------------------------------------------------------

        #endregion

        #region Part4
        public static void Part4()
        {
            Console.Clear();
            Console.WriteLine("Part 4 -- Out Parameters");
            Console.WriteLine("(1) Create a method to use 2 out parameters: x and y. Randomly set them to valid positions in the window.");
            Console.WriteLine("(2) Call the method to get the x and y and use them for the deadpool position.");


            //-------------------------------------------------------------------------------------------
            //
            // Call the method to get the x and y and use them for the deadpool position
            //
            //-------------------------------------------------------------------------------------------



            //-------------------------------------------------------------------------------------------

            //set X and Y to the variables used when calling your method
            GameObject deadpool = new GameObject() { X = Console.WindowWidth / 2, Y = Console.WindowHeight / 2, Symbol = deadPool, Back = ConsoleColor.Red, Fore = ConsoleColor.White };
            deadpool.DrawMe();

            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);

        }
        //-------------------------------------------------------------------------------------------
        //
        // Create a method to use 2 out parameters: x and y.
        // Randomly set them to valid positions in the window.
        // HINT: use Console.WindowWidth as the upper range for X and Console.WindowHeight as the upper range for Y
        //
        //-------------------------------------------------------------------------------------------

        #endregion

    }

    public static class Graphics
    {
        public static void DrawBlock()
        {
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2;

            Console.SetCursorPosition(x, y);
            Console.BackgroundColor = ConsoleColor.DarkCyan;

            Console.Write("     ");

            Console.ResetColor();
        }
        public static void ShowResult(bool result)
        {
            Console.SetCursorPosition(0, 7);
            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("RESULT: Success!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("RESULT: Not quite. Try again.");
            }
            Console.ResetColor();
        }
    }
}
