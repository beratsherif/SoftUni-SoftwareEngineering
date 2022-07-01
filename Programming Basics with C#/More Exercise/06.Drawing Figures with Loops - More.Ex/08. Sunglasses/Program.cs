using System;

namespace _08._Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            double check = Math.Abs(((n - 2) - 1) / 2);
            for (int i = 0; i < n - 2; i++)
            {
                if (i == check)
                {
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*");
                    Console.Write(new string('|', n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.Write("*");
                    Console.Write(new string(' ', n));
                    Console.Write("*");
                    Console.Write(new string('/', 2 * n - 2));
                    Console.WriteLine("*");
                }
            }
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
        }
    }
}
