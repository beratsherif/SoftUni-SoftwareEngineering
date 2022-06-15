using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int workingDay = 63;
            const int freeDay = 127;
            const int days = 365;
            const int playingTime = 30000;

            int freeDaysForTheMan = int.Parse(Console.ReadLine());

            int workingDaysForTheMan = days - freeDaysForTheMan;

            int totalPlayingTime = (freeDaysForTheMan * freeDay) + (workingDaysForTheMan * workingDay);

            int diff = Math.Abs(playingTime - totalPlayingTime);
            int hoursDiff = diff / 60;
            int minutiesDiff = diff % 60;

            if (totalPlayingTime > playingTime)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hoursDiff} hours and {minutiesDiff} minutes more for play");
            }
            else
            {
                Console.WriteLine($"Tom sleeps well");
                Console.WriteLine($"{hoursDiff} hours and {minutiesDiff} minutes less for play");
            }

        }
    }
}
