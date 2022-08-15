using System;

namespace _06._Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char lastSector = char.Parse(Console.ReadLine());
            int firstSectorPlaces = int.Parse(Console.ReadLine());
            int oddRowPlaces = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char sector = 'A'; sector <= lastSector; sector++)
            {
                for (int row = 1; row <= firstSectorPlaces; row++)
                {
                    char symbol = 'a';
                    if (row % 2 != 0)
                    {
                        for (int place = 1; place <= oddRowPlaces; place++)
                        {
                            Console.WriteLine($"{sector}{row}{symbol}");
                            symbol++;
                            counter++;
                        }
                    }
                    else
                    {
                        for (int place = 1; place <= oddRowPlaces + 2; place++)
                        {
                            Console.WriteLine($"{sector}{row}{symbol}");
                            symbol++;
                            counter++;
                        }
                    }
                }
                    firstSectorPlaces++;
            }
            Console.WriteLine(counter);
        }
    }
}
