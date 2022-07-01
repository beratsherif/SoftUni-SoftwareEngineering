using System;

namespace _06._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int top = 1; top <= n; top++)
            {
                for (int i = 1; i <= n - top; i++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= top; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int bot = n - 1; bot >= 1; bot--)
            {
                for (int i = n - bot; i >= 1; i--)
                {
                    Console.Write(" ");
                }
                for (int j = bot; j >= 1; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
