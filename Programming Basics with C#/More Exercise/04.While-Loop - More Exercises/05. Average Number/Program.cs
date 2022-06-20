using System;

namespace _05._Average_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                total += num;
            }
            double average = total / n;
            Console.WriteLine($"{average:f2}");
        }
    }
}
