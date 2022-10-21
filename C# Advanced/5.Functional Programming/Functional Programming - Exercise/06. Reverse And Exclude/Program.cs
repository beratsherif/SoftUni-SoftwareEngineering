using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int n = int.Parse(Console.ReadLine()); // Input.


            Func<List<int>, List<int>> reverse = numbers => // Reverse Func.
            {
                List<int> reversedResult = new List<int>();

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    reversedResult.Add(numbers[i]);
                }

                return reversedResult;
            };

            Func<List<int>, Predicate<int>, List<int>> removedResut = (numbers, match) => // Func for result.
            {
                List<int> removedList = new List<int>();

                foreach (var num in numbers)
                {
                    if (!match(num))
                    {
                        removedList.Add(num);
                    }
                }
                return removedList;
            };

            inputNums = removedResut(inputNums, num => num % n == 0);
            inputNums = reverse(inputNums);
            Console.WriteLine(string.Join(" ", inputNums));
        }
    }
}
