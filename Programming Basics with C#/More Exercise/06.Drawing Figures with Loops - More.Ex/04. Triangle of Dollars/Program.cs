using System;

namespace _04._Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("$");
                for (int l = 0; l < i; l++)
                {
                    Console.Write(" $");
                }
                Console.WriteLine();
            }
        }
    }
}
