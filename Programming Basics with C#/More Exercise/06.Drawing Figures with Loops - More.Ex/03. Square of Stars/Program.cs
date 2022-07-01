using System;

namespace _03._Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int l = 0; l < n; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
