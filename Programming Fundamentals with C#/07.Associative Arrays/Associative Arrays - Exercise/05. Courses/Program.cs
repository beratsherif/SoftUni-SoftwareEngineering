using System;
using System.Collections.Generic;
namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" : ",StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "end")
                {
                    break;
                }

                string courseName = command[0];
                string studentName = command[1];

                if (!list.ContainsKey(courseName))
                {
                    list[courseName] = new List<string>();
                }

                list[courseName].Add(studentName);
            }

            PrintingEveryStudentInfo(list);
        }
        static void PrintingEveryStudentInfo (Dictionary<string, List<string>> list)
        {
            foreach (var student in list)
            {
                string courseName = student.Key;
                List<string> students = student.Value;
                Console.WriteLine($"{courseName}: {students.Count}");

                foreach (var stdnt in students)
                {
                    Console.WriteLine($"-- {stdnt}");
                }
            }
        }
    }
}
