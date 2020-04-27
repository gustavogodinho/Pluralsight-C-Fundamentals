using System;
using  System.Collections.Generic;
namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var item in grades)
            {
                lowGrade = Math.Min(item, lowGrade);
                highGrade = Math.Max(item, highGrade);
                result += item;
            }
            result /= grades.Count;

            System.Console.WriteLine($"The lowest grade is {lowGrade:N1}");
            System.Console.WriteLine($"The highest grade is {highGrade:N1}");
            System.Console.WriteLine($"The average grade is {result:N1}");


        }
    }
}