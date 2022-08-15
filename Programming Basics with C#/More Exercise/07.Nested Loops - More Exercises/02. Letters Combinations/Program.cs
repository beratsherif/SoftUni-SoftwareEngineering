using System;

namespace _02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char finish = char.Parse(Console.ReadLine());
            char miss = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = start; i <= finish; i++)
            {
                for (char j = start; j <= finish; j++)
                {
                    for (char l = start; l <= finish; l++)
                    {
                        if (i == miss || j == miss || l == miss)
                        {
                            continue;
                        }
                        else
                        {
                            counter++;
                            Console.Write($"{i}{j}{l} ");
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
