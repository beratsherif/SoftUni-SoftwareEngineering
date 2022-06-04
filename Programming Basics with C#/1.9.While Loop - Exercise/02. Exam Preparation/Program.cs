using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double total = 0;
            int couter = 0;
            int totalProblems = 0;
            string lastProblem = string.Empty;
            bool check = false;
            while (input != "Enough")
            {
                lastProblem = input;
                double currGrade = double.Parse(Console.ReadLine());
                totalProblems++;
                total += currGrade;
                if (currGrade <= 4.00)
                {
                    couter++;
                }
                if (couter >= n)
                {
                    check = true;
                    break;
                }
                else
                {
                    input = Console.ReadLine();
                }

            }
            if (check)
            {
                Console.WriteLine($"You need a break, {couter} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {total / totalProblems:f2}");
                Console.WriteLine($"Number of problems: {totalProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
