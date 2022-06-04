using System;

namespace _08._Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxVal = int.MinValue;
            int minVal = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxVal)
                {
                    maxVal = currentNum;
                }
                if (currentNum < minVal)
                {
                    minVal = currentNum;
                }
            }
            Console.WriteLine($"Max number: {maxVal}");
            Console.WriteLine($"Min number: {minVal}");
        }
    }
}
