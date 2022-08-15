using System;

namespace _05._Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int men = int.Parse(Console.ReadLine());
            int women = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());
            for (int i = 1; i <= men; i++)
            {
                for (int j = 1; j <= women; j++)
                {
                    Console.Write($"({i} <-> {j}) ");
                    tables--;
                    if (tables < 1)
                    {
                        return;
                    }
                }
            }
        }
    }
}
