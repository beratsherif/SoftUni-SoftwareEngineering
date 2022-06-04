using System;

namespace _01._Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int minuties = 0; minuties <= 59; minuties++)
                {
                    Console.WriteLine($"{hours}:{minuties}");
                }
            }
        }
    }
}
