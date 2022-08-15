using System;

namespace _12._The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int counter = 0;
            int num = 0;
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (((a * b) + (c * d) == n) && a < b && c > d)
                            {
                                counter++;
                                Console.Write($"{a}{b}{c}{d} ");
                                if (counter == 4)
                                {
                                    num = (a * 1000) + (b * 100) + (c * 10) + d;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            if (counter >= 4)
            {
                Console.WriteLine($"Password: {num}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
