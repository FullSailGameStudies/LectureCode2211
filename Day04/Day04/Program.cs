using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;

namespace Day04
{
    enum Superpower
    {
        Flight, Strength, LaserEyes, Money, Telepathy, Speed, Invisibility, Fire
    }
    class Superhero
    {
        public string Name { get; set; }
        public string Secret { get; set; }
        public Superpower Power { get; set; } = Superpower.Money;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FileIO();

            Course pg2 = new Course() { Name = "PG2 - 2211" };

            string[] menu = new string[]
            {"0. Exit", "1. Part 1 - Saving CSV", "2. Part 2 - Reading CSV", "3. Part 3 - Serializing JSON", "4. Part 4 - Deserializing JSON","5. Part 5 - Recursive Loop"};

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

                if (int.TryParse(input, out part) && part > 0 && part < 6)
                {
                    switch (part)
                    {
                        case 1:
                            //Add a method SaveGrades to the Course class
                            //  save the dictionary to a csv file
                            //call SaveGrades here 
                            pg2.SaveGrades();
                            break;
                        case 2:
                            //Add a method LoadGrades to the Course class
                            //  clear the _grades dictionary
                            //  load the dictionary data from the csv file
                            //call LoadGrades here
                            pg2.LoadGrades();
                            break;
                        case 3:
                            //Add a SerializeGrades method to the Course class
                            //  serialize the dictionary to a json file
                            //call SerializeGrades here 
                            pg2.SerializeGrades();
                            break;
                        case 4:
                            //Add a DeserializeGrades method to the Course class
                            //  clear the _grades dictionary
                            //  deserialize the json file to the dictionary
                            //call DeserializeGrades here 
                            break;
                        case 5:
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

        private static void FileIO()
        {
            string filePath = @"C:\temp\2211\supers.csv";
            char delimiter = '^';
            //1. Open the file
            #region Writing CSV
            using (StreamWriter sw = new StreamWriter(filePath))//IDisposable
            {
                //2. Write to the file
                sw.Write("Batman");
                sw.Write(delimiter);
                sw.Write("Aquaman");
                sw.Write(delimiter);
                sw.Write("Flyboy(Superman)");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(13.7);
                sw.Write(delimiter);
                sw.Write(true);
            }//3. Close the file 
            #endregion

            #region Reading CSV
            string fileData = File.ReadAllText(filePath); //opens, reads, closes the file
            string[] data = fileData.Split(delimiter);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Writing JSON
            List<Superhero> JLA = new();
            JLA.Add(new Superhero() { Name = "Batman", Secret = "Bruce Wayne", Power = Superpower.Money });
            JLA.Add(new Superhero() { Name = "Wonder Woman", Secret = "Diana Prince", Power = Superpower.Strength });
            JLA.Add(new Superhero() { Name = "Superman", Secret = "Clark Kent", Power = Superpower.Flight });
            JLA.Add(new Superhero() { Name = "Flash", Secret = "Barry Allen", Power = Superpower.Speed });
            JLA.Add(new Superhero() { Name = "Martian Manhunter", Secret = "John Jones", Power = Superpower.Telepathy });

            //serialize to a file in JSON format
            filePath = Path.ChangeExtension(filePath, ".json");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Formatting = Formatting.Indented;
                    jsonSerializer.Serialize(jtw, JLA);
                }
            }
            #endregion
        }
    }
}
