using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadKey();
            //int size = Math.Min(Console.WindowWidth, Console.WindowHeight)-1;
            //int x = 0, y = 0;
            //for (int i = size; i >0; i-=2)
            //{
            //    Graphics.DrawBox(x++, y++, i, ConsoleColor.Red);
            //}
            ulong result = Factorial(5);
            Console.WriteLine($"5! = {result}");
            string s1 = "Batman", s2 = "Batmen";
            int compResult = s1.CompareTo(s2);
            // -1 : LESS THAN
            //  0 : EQUAL TO
            //  1 : GREATER THAN
            if (compResult == 0) Console.WriteLine($"{s1} EQUALS {s2}");
            else if(compResult < 0) Console.WriteLine($"{s1} LESS THAN {s2}");
            else if (compResult > 0) Console.WriteLine($"{s1} GREATER THAN {s2}");

            Console.ReadKey();
            //Loopit(0);
            Console.ResetColor();
            //Console.ReadKey();

            string[] menu = new string[]
            {"0. Exit", "1. Part 1 - Bats", "2. Part 2 - Fibonacci", "3. Part 3 - Swap", "4. Part 4 - Split"};

            int part = 1;
            _fibs.Add(0, 0);
            _fibs[1] = 1;
            while (true)
            {
                Console.Clear();

                #region Show Menu
                Console.WriteLine("What part to run?");
                foreach (var option in menu)
                    Console.WriteLine(option);
                Console.Write("Choice? ");
                string input = Console.ReadLine();
                #endregion

                if (int.TryParse(input, out part) && part > 0 && part < menu.Length)
                {
                    switch (part)
                    {
                        case 1:
                            Console.WriteLine("Part 1 - Bats");
                            //Add a static Bats method to this file
                            //  convert this for loop to a recursive loop using the Bats method
                            /*
                                for(int i = 0;i < 100;i++)
                                {
                                    Console.Write((char)78);
                                    Console.Write((char)65);
                                    Console.Write(' ');
                                }
                             */
                            //call Bats here
                            Bats(0);
                            Console.ResetColor();
                            Console.Write((char)66);
                            Console.Write((char)65);
                            Console.Write((char)84);
                            Console.Write((char)77);
                            Console.Write((char)65);
                            Console.Write((char)78);
                            Console.WriteLine("!");
                            break;
                        case 2:
                            Console.WriteLine("Part 2 - Fibonacci");
                            //Add a static Fibonacci method to this file
                            //  recursively calculate the Fibonacci of a number. 
                            //  EX: Fibonnaci(N) = Fibonnaci(N-1) + Fibonanci(N-2)
                            //      Fibonacci(0) = 0 and Fibonacci(1) = 1

                            //loop 45 times here and call Fibonacci on the for loop variable
                            //  print the result for each call to Fibonacci
                            Stopwatch stopper = new Stopwatch();
                            for (uint i = 0; i < 145; i++)
                            {
                                stopper.Restart();
                                result = Fibonacci2(i);
                                stopper.Stop();
                                long ms = stopper.ElapsedMilliseconds;
                                Console.Write($"Fibonacci2({i}) = {result}");
                                Console.CursorLeft = 40;
                                Console.WriteLine($"{ms} ms");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Part 3 - Swap");
                            List<int> nums = new() { 5, 13, 7, 3, 420 };
                            int index1 = 1, index2 = 2;
                            PrintList(nums);
                            Swap(nums, index1, index2);
                            PrintList(nums);
                            //Add a static Swap method to this file
                            //  Parameters: a list of ints and 2 ints for the indexes to swap
                            //  The method should swap the items at the 2 indexes
                            //
                            //Call Swap from main and pass in a list of ints and 2 indexes to swap
                            //print the list after calling swap to verify that the items were swapped
                            break;
                        case 4:
                            Console.WriteLine("Part 4 - Split");
                            //Add a static Split method to this file
                            //  Parameters: a list of ints
                            //  The method should use the Split portion to create 2 lists from 1 list
                            //  After splitting the list into 2 lists, print the left list and the right list
                            //
                            /*
                                var left := empty list
                                var right:= empty list
                                for i = 0 to length(m) do
                                        if i < (length of m)/ 2 then
                                            add m[i] to left
                                  else
                                    add m[i] to right
                            */
                            List<int> numbers = new() { 5, 13, 3, 42, -1 };
                            Split(numbers);

                            //Call Split from main with a list of ints
                            break;
                        default:
                            break;
                    }
                }
                else
                    break;
                Console.ReadKey();
            }
        }

        /*
            var left := empty list
            var right:= empty list
            for i = 0 to length(m) do
                    if i < (length of m)/ 2 then
                        add m[i] to left
              else
                add m[i] to right
        */
        private static void Split(List<int> m)
        {
            PrintList(m, "m");
            var left = new List<int>();
            var right = new List<int>();
            int mid = m.Count / 2;
            for (int i = 0; i < m.Count; i++)
            {
                if(i < mid)
                    left.Add(m[i]);
                else
                    right.Add(m[i]);
            }
            PrintList(left,  " Left: ");
            PrintList(right, "Right: ");
        }

        private static void Swap(List<int> nums, int index1, int index2)
        {
            //int temp = nums[index1];
            //nums[index1] = nums[index2];//overwrite index1
            //nums[index2] = temp;
            (nums[index2], nums[index1]) = (nums[index1], nums[index2]);
        }

        private static void PrintList(List<int> nums, string name = "Nums")
        {
            Console.Write($"{name}: ");
            foreach (var item in nums)
                Console.Write($"{item} ");
            Console.WriteLine();
        }

        static Dictionary<uint, ulong> _fibs = new Dictionary<uint, ulong>();
        private static ulong Fibonacci2(uint i)
        {
            if (_fibs.TryGetValue(i, out ulong result))
                return result;

            result = Fibonacci2(i - 1) + Fibonacci2(i - 2);
            _fibs[i] = result;
            return result;
        }
        private static ulong Fibonacci(uint i)
        {
            if (i == 0) return 0;
            if (i == 1) return 1;

            ulong result = Fibonacci(i - 1) + Fibonacci(i - 2);
            return result;
        }

        /*
for(int i = 0;i < 100;i++)
{
   Console.Write((char)78);
   Console.Write((char)65);
   Console.Write(' ');
}
*/
        private static void Bats(int i)
        {
            if (i < 100)//exit condition
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(i + 1);//make a recursive call

                Console.ForegroundColor = (ConsoleColor)randy.Next(16);
                Console.Write("!");
            }
        }

        static ulong Factorial(uint N)
        {
            if (N <= 1) return 1;

            ulong result = N * Factorial(N - 1);
            return result;
        }

        static Random randy = new Random();
        private static void Loopit(int i)
        {
            //exit condition
            if (i < Console.WindowWidth)
            {
                Console.BackgroundColor = (ConsoleColor)randy.Next(16);
                Console.Write(' ');
                Thread.Sleep(5);
                Loopit(i + 1);
            }
            if (Console.CursorLeft > 0)
                Console.CursorLeft--;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Write(' ');
            if (Console.CursorLeft > 0)
                Console.CursorLeft--;
            Thread.Sleep(5);
        }
    }

    static class Graphics
    {
        public static void DrawBox(int x, int y, int size, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            DrawHLine(x, y, size);
            DrawHLine(x, y + size, size);
            DrawVLine(x, y, size);
            DrawVLine(x + size, y, size);
            Console.ResetColor();
        }

        private static void DrawVLine(int x, int y, int size)
        {
            for(int i=y;i<=y+size;i++)
            {
                Console.SetCursorPosition(x, i);
                Console.Write(' ');
            }
        }

        private static void DrawHLine(int x, int y, int size)
        {
            Console.SetCursorPosition(x, y);
            for (int i = x; i <= x + size; i++)
            {
                Console.Write(' ');
            }
        }
    }
}
