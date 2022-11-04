﻿using System;
using System.Collections.Generic;

namespace Day06
{

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[]
            {"0. Exit", "1. Part 1 - Linear", "2. Part 2 - Draw Crosshairs", "3. Part 3 - Draw Diagonals", "4. Part 4 - Draw Random"};

            int part = 1;
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
                            Console.WriteLine("Part 1 - Linear");
                            List<int> nums = new() { 5, 13, 7, 3, 420 };
                            // create a method called LinearSearch
                            //      Parameter: list of ints, int searchNumber
                            //      Returns: -1 if not found or the index if found
                            //      use the linear search algorithm to try to find the searchNumber in the list
                            //      The algorithm:
                            //          start at the beginning.
                            //          stop when you reach the end OR you find the item.
                            //          return the index of the found item OR -1 if not found

                            Console.Write("Number to find: ");
                            if (int.TryParse(Console.ReadLine(), out int numToFind))
                            {
                                int foundIndex = LinearSearch(nums, numToFind);
                                if (foundIndex != -1)
                                    Console.WriteLine($"{numToFind} was found at index {foundIndex}");
                                else
                                    Console.WriteLine($"{numToFind} was NOT found!");
                            }
                            else
                                Console.WriteLine("That's not a number STEVE!");
                            //Call the linear search method. EX: int index = LinearSearch(nums, 5);
                            //print the results
                            break;
                        case 2:
                            Console.WriteLine("Part 2 - Draw Crosshairs");
                            //
                            //Convert the pseudo-code in the Graphics class to 3 static methods: plotLineLow, plotLineHigh, plotLine
                            //

                            //call plotLine to draw crosshairs in the console
                            break;
                        case 3:
                            Console.WriteLine("Part 3 - Draw Diagonals");
                            //call plotLine to draw diagonal lines in the console from corners to corners (top,left to bottom,right and bottom,left to top,right)
                            break;
                        case 4:
                            Console.WriteLine("Part 4 - Draw Random");
                            //call plotLine to draw 1000 random lines in the console
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

        private static int LinearSearch(List<int> nums, int numToFind)
        {
            int foundIndex = -1;
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == numToFind)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }

        private static void PrintList(List<int> nums, string name = "Nums")
        {
            Console.Write($"{name}: ");
            foreach (var item in nums)
                Console.Write($"{item} ");
            Console.WriteLine();
        }
    }

    static class Graphics
    {
        /*
         plotLineLow(x0,y0, x1,y1) 
             dx = x1 - x0 
             dy = y1 - y0 
             yi = 1 

             if dy < 0 
                yi = -1 
                dy = -dy 
             end if

             D = 2*dy - dx 
             y = y0 

             for x from x0 to x1 
                plot(x, y) //draw a space at the x,y coordinates

                if D > 0 
                    y = y + yi 
                    D = D - 2*dx 
                end if

                D = D + 2*dy 
         */

        /*
         plotLineHigh(x0,y0, x1,y1) 
            dx = x1 - x0 
            dy = y1 - y0 
            xi = 1 

            if dx < 0 
                xi = -1 
                dx = -dx 
            end if
             
            D = 2*dx - dy 
            x = x0 

            for y from y0 to y1 
                plot(x, y) //draw a space at the x,y coordinates

                if D > 0 
                    x = x + xi 
                    D = D - 2*dy 
                end if

                D = D + 2*dx 

         */

        /*
         plotLine(x0,y0, x1,y1) 
            if abs(y1 - y0) < abs(x1 - x0) 
                if x0 > x1 
                    plotLineLow(x1, y1, x0, y0) 
                else
                    plotLineLow(x0, y0, x1, y1)  
                end if
            else
                if y0 > y1 
                    plotLineHigh(x1, y1, x0, y0)
                else
                    plotLineHigh(x0, y0, x1, y1) 
                end if
            end if
         */

    }
}
