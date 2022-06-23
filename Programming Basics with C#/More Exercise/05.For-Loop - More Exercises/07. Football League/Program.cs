using System;

namespace _07._Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fans = int.Parse(Console.ReadLine());
            int sectorA = 0;
            int sectorB = 0;
            int sectorV = 0;
            int sectorG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();
                switch (sector)
                {
                    case "A":
                        sectorA++;
                        break;
                    case "B":
                        sectorB++;
                        break;
                    case "V":
                        sectorV++;
                        break;
                    case "G":
                        sectorG++;
                        break;
                }
            }
            Console.WriteLine($"{(double)sectorA / fans * 100.00:f2}%");
            Console.WriteLine($"{(double)sectorB / fans * 100.00:f2}%");
            Console.WriteLine($"{(double)sectorV / fans * 100.00:f2}%");
            Console.WriteLine($"{(double)sectorG / fans * 100.00:f2}%");
            Console.WriteLine($"{(double)fans / stadiumCapacity * 100.00:f2}%");

        }
    }
}
