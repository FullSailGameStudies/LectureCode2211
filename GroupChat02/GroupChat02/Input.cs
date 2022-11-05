using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace PG2Input
{
    public static class Input
    {
        //Part A-2: GetInput
        //Create a method called GetInput that will ask the user to input something. The method 
        //should show the message parameter, read the user’s input, and return the input.
        public static string GetInput(string message)
        {
            //Add code to this method to do the following:
            //- show the message
            Console.Write(message);
            //- get the user's input
            string input = Console.ReadLine();
            //- return the input
            return input;
        }


        //Part A-3: ValidInteger
        //Create a method called ValidInteger that will return true/false if the integer that is passed in is within the min and max range 
        //(inclusively). NOTE: the number, min and max are parameters that are passed in to the method.
        public static bool ValidInteger(int number, int min, int max)
        {
            return number >= min && number <= max;
        }



        //Part A-4: GetInteger
        //Create a method called GetInteger that will return an integer that fits within a min/max
        //range.Call GetInput to get the user’s input.Convert the string that is returned from
        //GetInput to an integer. DO NOT THROW AN UNHANDLED EXCEPTION. If the input is a
        //number, then call ValidInteger to check if the number is within the min/max range.
        //Return the number if it is valid.If the user’s input is not a number OR the number is not
        //valid, print an error message. Do not return until the user enters a valid integer.
        //Therefore, you’ll need a loop.
        public static int GetInteger(string message, int min, int max)
        {
            do
            {
                string input = GetInput(message);
                if (int.TryParse(input, out int result) && ValidInteger(result, min, max))
                    return result;
                Console.WriteLine($"{input} is not a valid number between {min} and {max}");
            } while (true);
        }



        //Part A-5: ValidString
        //Create a method called ValidString that will return true/false if the string that is passed in is not null and not empty. You should use
        //the IsNullOrEmpty or the IsNullOrWhiteSpace methods of the string class to check if the string is empty.
        public static bool ValidString(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }


        //Part A-6: GetString
        //Create a method called GetString that will ask the user for a string. Instead of 
        //returning the value like in GetInteger, you should use pass by reference to get the\
        //string back to the caller.Call GetInput to get the user’s input and store the input in
        //the ref parameter.Call ValidString to check if the input is valid.Return if it is valid.If
        //the user’s input is not valid, print an error message.Do not return until the user
        //enters something.Therefore, you’ll need a loop.
        public static void GetString(string message, ref string input)
        {
            do
            {
                input = GetInput(message);
                if (ValidString(input))
                    break;
                Console.WriteLine("That is not a valid entry.");
            } while (true);
        }



        //Part A-7: GetMenuChoice
        //Create a method called GetMenuChoice that will ask the user to select from a list of 
        //options.Instead of returning like GetInteger or passing back the value like GetString,
        //you should return the menu selection through an out parameter.The method should
        //show a list of options to the user(the menuOptions parameter). Get the user’s
        //selection by calling GetInteger and assign the integer to the out parameter.
        public static void GetMenuChoice(string message, string[] menuOptions, out int menuSelection)
        {
            foreach(string option in menuOptions)
                Console.WriteLine(option);

            menuSelection = GetInteger(message, 1, menuOptions.Length);
        }

    }
}
