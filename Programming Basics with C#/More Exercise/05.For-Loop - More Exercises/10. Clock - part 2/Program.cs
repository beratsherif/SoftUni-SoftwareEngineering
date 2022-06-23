using System;

namespace _10._Clock___part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int hour = 0; hour <= 23; hour++)
            {
                for (int min = 0; min <= 59; min++)
                {
                    for (int sec = 0; sec <= 59; sec++)
                    {
                        Console.WriteLine($"{hour} : {min} : {sec}");
                    }
                }
            }
        }
    }
}
