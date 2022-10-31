using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class Course
    {
        private Dictionary<string, double> _grades;
        private string _filePath = @"C:\temp\2211\pg2_2211.csv";

        public string Name { get; set; } = String.Empty;

        public Course()
        {
            FillGrades();
        }

        public void SaveGrades()
        {
            //1.Open the file
            using (StreamWriter sw = new StreamWriter(_filePath))
            {
                //2. Write the file
                bool isFirst = true;
                foreach (var student in _grades)
                {
                    if (!isFirst)
                        sw.Write(';');
                    sw.Write($"{student.Key}:{student.Value}");
                    isFirst = false;
                }
            }//3. Close the file
        }

        public void LoadGrades()
        {
            _grades.Clear();
            string fileData = File.ReadAllText(_filePath);
            string[] kvps = fileData.Split(';');
            foreach (var kvp in kvps)
            {
                string[] kvpData = kvp.Split(':');
                if (double.TryParse(kvpData[1], out double grade))
                {
                    _grades.Add(kvpData[0], grade);
                }
            }
            PrintGrades();
        }


        public void SerializeGrades()
        {
            string filePath = Path.ChangeExtension(_filePath, ".json");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    JsonSerializer jsonSerializer = new JsonSerializer();
                    jsonSerializer.Formatting = Formatting.Indented;
                    jsonSerializer.Serialize(jtw, _grades);
                }
            }
        }

        #region Day03 Code
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
            if (_grades == null) FillGrades();
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
            if (_grades == null) FillGrades();
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
        public void CurveStudent()
        {
            if (_grades == null) FillGrades();
            do
            {
                PrintGrades();
                Console.Write("Student to curve? ");
                string student = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(student)) break;

                if (_grades.TryGetValue(student, out double grade))
                {
                    _grades[student] = Math.Min(100, grade + 5);
                    PrintGrades();
                    Console.WriteLine($"{student} was curved from {grade} to {_grades[student]}.");
                }
                else
                    Console.WriteLine($"{student} was not in {Name}.");
            } while (true);
        }
        #endregion
    }
}