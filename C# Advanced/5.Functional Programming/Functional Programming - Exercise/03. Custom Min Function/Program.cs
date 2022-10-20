using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestNum = nums =>
            {

                int min = int.MaxValue;
                foreach (var num in nums)
                {
                    if (num < min)
                    {
                        min = num;
                    }
                }

                return min;
            };

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            Console.WriteLine(smallestNum(numbers));
        }
    }
}
