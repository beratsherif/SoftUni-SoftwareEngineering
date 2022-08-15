using System;

namespace _13._Even_couples
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int firstMax = int.Parse(Console.ReadLine());
            int secondMax = int.Parse(Console.ReadLine());


            for (int i = first; i <= first + firstMax; i++)
            {
                for (int l = second; l <= second + secondMax; l++)
                {
                    int counter = 2;
                    if (i % 2 == 0 || l % 2 == 0 || i % 3 == 0 || l % 3 == 0 || i % 5 == 0 || l % 5 == 0 || i % 7 == 0 || l % 7 == 0)
                    {
                        counter++;
                    }
                    if (counter == 2)
                    {
                        Console.Write($"{i}{l} ");
                    }
                }
            }

        }
    }
}
