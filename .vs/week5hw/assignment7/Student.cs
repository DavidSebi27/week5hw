using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment7
{
    internal class Student
    {
        public string name;
        public int[] grades;

        public Student(string name, int[] grades)
        {
            this.name = name;
            this.grades = grades;
        }

        public double CalculateAverage()
        {
            double sum = 0;

            for (int i = 0; i < this.grades.Length; i++)
            {
                sum += this.grades[i];
            }

            return sum/this.grades.Length;
        }

        public void DisplayGrades()
        {
            Console.WriteLine($"Grades for {name}: ");
            int i = 0;
            for (i = 0; i < this.grades.Length - 1; i++)
            {
                Console.Write(this.grades[i] + ", ");
            }
            Console.WriteLine(this.grades[i]);
        }
    }
}
