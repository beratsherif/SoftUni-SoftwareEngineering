using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodeTime = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());

            double lunchTime = freeTime / 8.0;
            double restTime = freeTime / 4.0;

            double timeLeft = freeTime - lunchTime - restTime;
            double difference = Math.Abs(episodeTime - timeLeft);

            if (timeLeft >= episodeTime)
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(difference)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(difference)} more minutes.");
            }
        }
    }
}
