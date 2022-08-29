using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<double>();
                }
                    students[name].Add(grade);
            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{studentName} -> {averageGrade:f2}");
                }
            }
        }
    }
}
