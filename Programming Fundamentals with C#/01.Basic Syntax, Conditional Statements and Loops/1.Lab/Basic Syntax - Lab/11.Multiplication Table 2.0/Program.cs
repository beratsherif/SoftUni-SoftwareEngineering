using System;

namespace _11.Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            if (start > 10)
            {
                Console.WriteLine($"{n} X {start} = {n * start}");
            }
            for (int i = start; i <= 10; i++)
            {
                    Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
