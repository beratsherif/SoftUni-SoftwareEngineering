using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int w = int.Parse(Console.ReadLine());
            int h1 = int.Parse(Console.ReadLine());
            int freeSpace = h * w * h1;
            int occupiedPlace = 0;
            bool check = false;
            string input = Console.ReadLine();
            while (input != "Done")
            {
                int coutOfBoxes = int.Parse(input);
                occupiedPlace += coutOfBoxes;
                if (occupiedPlace >= freeSpace)
                {
                    check = true;
                    break;
                }
                input = Console.ReadLine();
            }
            if (check)
            {
                Console.WriteLine($"No more free space! You need {occupiedPlace - freeSpace} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{freeSpace - occupiedPlace} Cubic meters left.");
            }
        }
    }
}
