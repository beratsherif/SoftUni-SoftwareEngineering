using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int x = 0; x <= n; x++)
            {
                for (int y = 0; y <= n; y++)
                {
                    for (int z = 0; z <= n; z++)
                    {
                        if (x + y + z == n)
                        {
                            counter++;
                        }
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
