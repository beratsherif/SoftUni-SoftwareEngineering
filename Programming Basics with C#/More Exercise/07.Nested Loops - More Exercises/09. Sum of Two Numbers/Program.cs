using System;

namespace _09._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = first; i <= last; i++)
            {
                for (int j = first; j <= last; j++)
                {
                    counter++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magic}");
        }
    }
}
