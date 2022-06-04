using System;

namespace _08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int coutOfTournirs = int.Parse(Console.ReadLine());
            int startingPoint = int.Parse(Console.ReadLine());
            int pointsFromTournirs = 0;
            int wins = 0;
            for (int i = 0; i < coutOfTournirs; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W":
                        pointsFromTournirs += 2000;
                        wins++;
                        break;
                    case "F":
                        pointsFromTournirs += 1200;
                        break;
                    case "SF":
                        pointsFromTournirs += 720;
                        break;
                }
            }
            int totalPoints = pointsFromTournirs + startingPoint;
            double averagePointPromTournirs = (double)pointsFromTournirs / coutOfTournirs;
            double percentWins = (double)wins / coutOfTournirs * 100.00;
            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(averagePointPromTournirs)}");
            Console.WriteLine($"{percentWins:f2}%");
        }
    }
}
