using System;

namespace _10._Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevaC = int.Parse(Console.ReadLine());
            int twoLevaC = int.Parse(Console.ReadLine());
            int fiveLevaC = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= oneLevaC; i++)
            {
                for (int j = 0; j <= twoLevaC; j++)
                {
                    for (int k = 0; k <= fiveLevaC; k++)
                    {
                        if ((i * 1) + (j * 2) + (k * 5) == sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
