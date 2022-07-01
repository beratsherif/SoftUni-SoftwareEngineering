using System;

namespace _05._Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write("+ ");
                    for (int l = 0; l < n - 2; l++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("+ ");
                }
                else
                {
                    Console.Write("| ");
                    for (int k = 0; k < n - 2; k++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("| ");
                }
            }
        }
    }
}
