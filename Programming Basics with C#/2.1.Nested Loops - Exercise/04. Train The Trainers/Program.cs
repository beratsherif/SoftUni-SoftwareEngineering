using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfJourey = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double totalGrade = 0;
            int totalGradesCounter = 0;
            while (input != "Finish")
            {
                double averageGrade = 0;
                for (int i = 0; i < coutOfJourey; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    totalGradesCounter++;
                    averageGrade += grade;
                }
                totalGrade += averageGrade;
                Console.WriteLine($"{input} - {averageGrade / coutOfJourey:f2}.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {totalGrade / totalGradesCounter:f2}.");
        }
    }
}
