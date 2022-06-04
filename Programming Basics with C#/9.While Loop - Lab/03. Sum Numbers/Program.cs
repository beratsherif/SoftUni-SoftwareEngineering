using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int total = num;
            while (total < input)
            {
                num = int.Parse(Console.ReadLine());
                total += num;
            }
            Console.WriteLine(total);
        }
    }
}
