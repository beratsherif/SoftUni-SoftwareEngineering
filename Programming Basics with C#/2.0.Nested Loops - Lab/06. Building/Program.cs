using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int room = int.Parse(Console.ReadLine());
            for (int floors = floor; floors >= 1; floors--)
            {
                string symbol = string.Empty;
                if (floor == floors)
                {
                    symbol = "L";
                }
                else
                {
                    if (floors % 2 == 0)
                    {
                        symbol = "O";
                    }
                    else
                    {
                        symbol = "A";
                    }
                }
                for (int rooms = 0; rooms < room; rooms++)
                {
                    Console.Write($"{symbol}{floors}{rooms} ");
                }
                Console.WriteLine();
            }
        }
    }
}
