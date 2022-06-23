using System;

namespace _04._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int student = int.Parse(Console.ReadLine());
            int topStudents = 0;
            int between4And499 = 0;
            int between3And399 = 0;
            int failedStudents = 0;
            double total = 0;

            for (int i = 0; i < student; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 2 && grade <= 2.99)
                {
                    failedStudents++;
                    total += grade;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    between3And399++;
                    total += grade;
                }
                else if (grade >= 4 && grade <= 4.99)
                {
                    between4And499++;
                    total += grade;
                }
                else if (grade >= 5 && grade <= 6)
                {
                    topStudents++;
                    total += grade;
                }
            }
            double averageGrade = total / student;
            Console.WriteLine($"Top students: {(double)topStudents / student * 100.00:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(double)between4And499 / student * 100.00:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(double)between3And399 / student * 100.00:f2}%");
            Console.WriteLine($"Fail: {(double)failedStudents / student * 100.00:f2}%");
            Console.WriteLine($"Average: {averageGrade:f2}");
        }
    }
}
