using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Course
    {
        private Dictionary<string, double> _grades;

        public string Name { get; set; } = String.Empty;

        public void FillGrades()
        {
            List<string> students = new List<string>()
            {
                "Anthony", "Julio", "Jeffrey", "ID", "Jonah", "Jake", "Jesus", "Sam",
                "Albert", "Hanna", "Connor", "Aidan", "Carter", "Alexis", "Kemarly",
                "Joaquin", "Enrique"
            };
            Random rando = new Random();
            _grades = new Dictionary<string, double>();
            _grades.Add("Steev", rando.NextDouble() * 100);
            _grades.Add("Anita", rando.NextDouble() * 100);
            _grades.Add("Cameron", rando.NextDouble() * 100);
            _grades.Add("dylan", rando.NextDouble() * 100);
            _grades.Add("Frankie", rando.NextDouble() * 100);
            _grades.Add("Japhet", rando.NextDouble() * 100);
            foreach (var student in students)
            {
                _grades[student] = rando.NextDouble() * 100;
            }
        }
        public void PrintGrades()
        {
            Console.WriteLine($"---------{Name}----------");
            foreach (var student in _grades)
            {
                string name = student.Key;
                double grade = student.Value;
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                          ConsoleColor.Green;
                Console.Write($"{grade,7:N2} ");
                Console.ResetColor();
                Console.WriteLine(name);
            }
        }

        public void DropStudent()
        {
            do
            {
                PrintGrades();
                Console.Write("Student to drop? ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;

                bool wasDropped = _grades.Remove(student);
                if (wasDropped)
                {
                    PrintGrades();
                    Console.WriteLine($"{student} was dropped from {Name}.");
                }
                else
                    Console.WriteLine($"{student} was not in {Name}.");
            } while (true);
        }
    }
}

//create a method called FillGrades
//  initialize the dictionary
//  add students and grades

//create a PrintGrades method
//  loop over dictionary and print student name and grade

//create a DropStudent method
//  loop
//      ask for the name of the student to drop
//      call Remove to remove the student
//      print message indicating what happened
//          error message if not found
//      else call printgrades and print that the student was removed


//create a CurveStudent method
//  loop
//      ask for the name of the student to curve
//      if student found
//          curve grade
//          call PrintGrades
//      else
//          print error message
