using System;
using System.Linq;
namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            int leftSum;
            int rightSum;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;

                for (int left = i; left > 0; left--)
                {
                    int nextLeftEl = left - 1;

                    if (left > 0)
                    {
                        leftSum += numbers[nextLeftEl];
                    }
                }

                rightSum = 0;
                for (int right = i; right < numbers.Length; right++)
                {
                    int nextElPos = right + 1;
                    if (right < numbers.Length - 1)
                    {
                        rightSum += numbers[nextElPos];
                    }
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
