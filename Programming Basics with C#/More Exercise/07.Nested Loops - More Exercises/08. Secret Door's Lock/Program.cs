using System;

namespace _08._Secret_Door_s_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hundretsBorder = int.Parse(Console.ReadLine());
            int tensBorder = int.Parse(Console.ReadLine());
            int onesBorder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= hundretsBorder; i++)
            {
                for (int j = 1; j <= tensBorder; j++)
                {
                    for (int k = 1; k <= onesBorder; k++)
                    {
                        if (i % 2 == 0 && k % 2 == 0 && (j == 2 || j == 3 || j == 5 || j == 7))
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
