using System;

namespace _08._Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 0;
            int second = 0;

            for (int i = 1; i <= n; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int total = firstNum + secondNum;
                if (i % 2 == 0)
                {
                    second = total;
                }
                else
                {
                    first = total;
                }
            }
            if (first == second || n == 1)
            {
                Console.WriteLine($"Yes, value={first}");
            }
            else
            {
                int diff = Math.Abs(first - second);
                Console.WriteLine($"No, maxdiff={diff}");
            }
        }
    }
}
