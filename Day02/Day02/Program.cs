using System;
using System.Collections.Generic;
//using System.Collections.Generic;
using System.Linq;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = "Batman;Bats;Dark Knight;;Joker:Bane:Mr. Freeze:Scarecrow";
            char[] delimiters = new char[] { ';', ':' };
            string[] nameData = names.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            int index = 0;
            foreach (string name in nameData)
            {
                Console.WriteLine($"{++index}. {name}");
            }
            Console.ReadKey();
            ListSamples();
            Course pg2 = new Course() { Name = "PG2 - 2211" };

            while (true)
            {
                Console.Clear();
                int part = 1;
                Console.Write("What part to run?\n0. Exit\n1. Part 1 - Creating and Adding\n2. Part 2 - Looping\n3. Part 3 - Removing\n4. Part 4 - Cloning\n5. Split\n6. Extras\nChoice? ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out part) && part > 0 && part < 6)
                {
                    switch (part)
                    {
                        case 1:
                            //Add a method FillGrades to the Course class
                            //  Initialize the _grades list
                            //  add 10 random grades 
                            //call FillGrades here 
                            pg2.FillGrades();
                            Console.WriteLine("Filled the grades!");
                            break;
                        case 2:
                            //Add a method PrintGrades to the Course class
                            //  loop over the _grades list
                            //      print each grade
                            //call PrintGrades here
                            pg2.PrintGrades();
                            break;
                        case 3:
                            //Add a method DropFailing to the Course class
                            //  loop over the _grades list
                            //      remove the grade if it's < 59.5
                            //  return the number of grades removed
                            //call DropFailing here and print the number of grades removed
                            //call PrintGrades here
                            int droppedGrades = pg2.DropFailing();
                            Console.WriteLine($"{droppedGrades} dropped.");
                            pg2.PrintGrades();
                            break;
                        case 4:
                            //Add a method CurveGrades(amount) to the Course class
                            //  clone the _grades list
                            //  loop over the cloned list
                            //      curve the grades (add +5 to each grade)
                            //  return the curved list
                            //call CurveGrades here 
                            Console.WriteLine("-------ORIGINAL------");
                            pg2.PrintGrades();
                            Console.WriteLine("-------CURVED------");
                            List<double> curved = pg2.CurveGrades(10);
                            pg2.PrintGrades(curved);
                            break;
                        case 5:
                            //Add a PrintData(string) method to the SplitText class
                            //  splits the parameter
                            //  print the array items
                            break;
                        case 6:
                            ExtraChallenges.Run();
                            break;
                        default:
                            break;
                    }
                    Console.ReadKey();
                }
                else
                    break;
            }
        }

        private static void ListSamples()
        {
            string[] data = new string[3] { "Batman", "Bats", "Bruce" };
            //1) call ToList
            List<string> data2 = data.ToList();

            //2) pass array to the list constructor
            List<string> data3 = new List<string>(data);

            //3) copy each item from the array to the list
            List<string> data4 = new List<string>();
            for (int i = 0; i < data.Length; i++)
            {
                data4.Add(data[i]);
            }

            List<string> best;//null
            best = new List<string>(10);// { "Batman", "Bats", "Bruce" };//creating an instance of List<string>
            Info(best);//Count:0  Capacity:0 
            best.Add("not Aquaman");//Count:1  Capacity:___ 1?  
            Info(best);
            best.Add("Batman");
            best.Add("Bats");
            best.Add("Bruce");//Count:4  Capacity:4
            best.Add("Dark Knight"); 
            Info(best);//Count:5  Capacity:8?16?
            best.Add("Wonder Woman");
            best.Add("Flash");
            best.Add("still not Aquaman");
            best.Add("Superman");//Count:9  Capacity:12? 16?  
            Info(best);
            best.Add("Robin");
            best.Add("Green Arrow");
            best.Add("Batgirl");
            Info(best);//Count:12  Capacity:

            for (int i = 0; i < best.Count; i++)
            {
                Console.WriteLine(best[i]);
            }
            Console.WriteLine("-----foreach-------");
            foreach (string super in best)
            {
                Console.WriteLine(super);
            }
        }
        private static void Info(List<string> myData)
        {
            //clone the original
            List<string> clone1 = myData.ToList();
            //clone1.RemoveAt(myData.Count - 1);

            List<string> clone2 = new List<string>(myData);

            //Count - # of items we've added
            //Capacity - Length of the internal array
            Console.WriteLine($"Count: {myData.Count}\tCapacity: {myData.Capacity}");
        }
    }
}
