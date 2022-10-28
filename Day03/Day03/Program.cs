using System;
using System.Collections.Generic;
using System.Linq;

namespace Day03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
            Course pg2 = new Course() { Name = "PG2 - 2211" };

            while (true)
            {
                Console.Clear();
                int part = 1;
                Console.Write("What part to run?\n0. Exit\n1. Part 1 - Creating and Adding\n2. Part 2 - Looping\n3. Part 3 - Removing\n4. Part 4 - Cloning\n5. Extras\nChoice? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out part) && part > 0 && part < 6)
                {
                    switch (part)
                    {
                        case 1:
                            //Add a method FillGrades to the Course class
                            //  initialize the dictionary
                            //  add students and grades
                            //call FillGrades here 
                            pg2.FillGrades();
                            break;
                        case 2:
                            //Add a method PrintGrades to the Course class
                            //  loop over dictionary 
                            //      print student name and grade
                            //call PrintGrades here
                            break;
                        case 3:
                            //Add a DropStudent method to the Course class
                            //  loop
                            //      ask for the name of the student to drop
                            //      call Remove to remove the student
                            //      print message indicating what happened
                            //          error message if not found
                            //      else call printgrades and print that the student was removed
                            break;
                        case 4:
                            //Add a CurveStudent method to the Course class
                            //  loop
                            //      ask for the name of the student to curve
                            //      if student found
                            //          curve grade
                            //          call PrintGrades
                            //      else
                            //          print error message
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
        }

        private static void Menu()
        {
            //3 ways to get data into the dictionary
            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //key,value
                {"French toast", 11.99F },
                {"Stuffed French toast", 13.99F }
            };

            //Add method
            menu.Add("omelette", 6.99F);

            try
            {
                menu.Add("omelette", 6.99F);//cause an exception
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR!!!");
            }

            menu.Add("pancakes", 8.99F);

            //[ ]
            menu["waffles"] = 7.99F;
            menu["shrimp and grits"] = 10.99F;
            menu["shrimp and grits"] = 12.99F;//overwrite. no exception.

            PrintMenu(menu);
        }
        static void PrintMenu(Dictionary<string,float> menu)
        {
            Console.WriteLine("----------Florida Man's Eatery-----------");
            foreach (var item in menu)
            {
                Console.WriteLine($"{item.Value,8:C2} {item.Key}");
            }
        }
    }
}
