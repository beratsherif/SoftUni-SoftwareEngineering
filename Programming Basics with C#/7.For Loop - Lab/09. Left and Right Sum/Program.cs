using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= n; i++)
            {
                int currNum = int.Parse(Console.ReadLine());
                sum1 += currNum;
            }
            for (int i = 0; i < n; i++)
            {
                int currNum2 = int.Parse(Console.ReadLine());
                sum2 += currNum2;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                int difference = Math.Abs(sum1 - sum2);
                Console.WriteLine($"No, diff = {difference}");
            }
        }
    }
}
