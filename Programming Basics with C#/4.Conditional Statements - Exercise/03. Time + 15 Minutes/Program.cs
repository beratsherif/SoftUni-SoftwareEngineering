using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int hour = int.Parse(Console.ReadLine()) * 60;
            //int minuties = int.Parse(Console.ReadLine());

            //int total = hour + minuties + 15;
            //int nextHour = total / 60;
            //int nextMinuties = total % 60;
            //if (hour == 1380 && minuties >= 45)
            //{
            //    nextHour = 0;
            //}
            //if (nextMinuties < 10)
            //{
            //    Console.WriteLine($"{nextHour}:{nextMinuties:d2}");
            //}
            //else
            //{
            //Console.WriteLine($"{nextHour}:{nextMinuties}");
            //}
            int hour = int.Parse(Console.ReadLine());
            int minuties = int.Parse(Console.ReadLine());
            minuties += 15;
            if (minuties >= 60)
            {
                hour += 1;
                minuties -= 60;
            }
            if (hour >= 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minuties:d2}");
        }
    }
}
