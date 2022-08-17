using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lines; i++)
            {
                PrintUpLines(1, i);
                Console.WriteLine();
            }
            for (int i = lines - 1; i >= 1; i--)
            {
                PrintDownLines(1, i);
                Console.WriteLine();
            }

        }
        static void PrintUpLines(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }

        static void PrintDownLines(int start,int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
