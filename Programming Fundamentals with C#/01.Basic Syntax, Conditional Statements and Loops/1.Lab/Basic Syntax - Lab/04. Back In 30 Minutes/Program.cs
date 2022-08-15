using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minuties = int.Parse(Console.ReadLine()) + 30;

            if (minuties > 59)
            {
                minuties -= 60;
                hour += 1;
            }
            if (hour == 24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minuties:d2}");
        }
    }
}
