using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    public class Course
    {
        private List<double> _grades;

        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Initialize and Fill the _grades list with 10 grades
        /// </summary>
        public void FillGrades()
        {
            _grades = new List<double>();//initialized the list
            Random rando = new Random();
            for (int i = 0; i < 10; i++)
            {
                _grades.Add(rando.NextDouble() * 100);
            }
        }

        /// <summary>
        /// Loops over the _grades and prints each grade
        /// </summary>
        public void PrintGrades(List<double> grades = null)
        {
            if (grades == null)
            {
                if (_grades == null) FillGrades();
                grades = _grades;
            }

            for (int i = 0; i < grades.Count; i++)
            {
                double grade = grades[i];
                if (grade < 59.5) Console.BackgroundColor = ConsoleColor.Red;
                else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                else if(grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                else Console.ForegroundColor = ConsoleColor.Green;

                // ,7 - right-aligns in 7 spaces
                // :N2 - number with 2 decimal places
                Console.WriteLine($"{grades[i],7:N2}");
                Console.ResetColor();
            }
        }

        public int DropFailing()
        {
            int dropped = 0;
            for (int i = 0; i < _grades.Count; i++)
            {
                if (_grades[i] < 59.5)
                {
                    dropped++;
                    _grades.RemoveAt(i);
                    i--;
                }
            }
            //for (int i = _grades.Count - 1; i >= 0; i--)
            //{
            //    if (_grades[i] < 59.5)
            //    {
            //        dropped++;
            //        _grades.RemoveAt(i);
            //    }
            //}
            return dropped;
        }

        public List<double> CurveGrades(int amountToCurve)
        {
            List<double> curved = _grades.ToList();//clone the original
            for (int i = 0; i < curved.Count; i++)
            {
                //ternary operator
                curved[i] = (curved[i] < (100 - amountToCurve)) ? curved[i] + amountToCurve : 100;
            }
            return curved;
        }
    }
}


//create a method FillGrades
//  Initialize the _grades list
//  add 10 random grades 
//  call FillGrades from Main

//create a method PrintGrades()
//  loop over the _grades list
//      print each grade
//  call PrintGrades from Main

//Create a method DropFailing
//  loop over the _grades list
//      remove the grade if it's < 59.5
//  return the number of grades removed
//  call DropFailing from Main and print the results
//  call PrintGrades from Main

//Create a method CurveGrades(amount)
//  clone the _grades list
//  loop over the cloned list
//      curve the grades
//  return the curved list
//  call CurveGrades from Main 

//create a static PrintGrades(list)
//  call the static version from PrintGrades
//  call the static version from Main to print the curved grades