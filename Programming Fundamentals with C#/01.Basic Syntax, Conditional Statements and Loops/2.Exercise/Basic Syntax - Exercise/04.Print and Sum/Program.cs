using System;

namespace _04.Print_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int total = 0;

            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                total += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {total}");
        }
    }
}
