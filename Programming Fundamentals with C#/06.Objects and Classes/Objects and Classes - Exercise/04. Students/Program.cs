using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            int countOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student currStudent = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
                students.Add(currStudent);
            }

            students = students.OrderByDescending(currStudent => currStudent.Grade).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
            /*students.ForEach(student => Console.WriteLine(student));*/   // another way!!!!!!!!!!!
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
    }
}
