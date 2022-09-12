using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int startIndex = 0, endIndex = 0;

            if (firstList.Count > secondList.Count)
            {
                startIndex = Math.Min(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
                endIndex = Math.Max(firstList[firstList.Count - 1], firstList[firstList.Count - 2]);
            }
            else
            {
                startIndex = Math.Min(secondList[0], secondList[1]);
                endIndex = Math.Max(secondList[0], secondList[1]);

            }

            List<int> result = firstList.Where(x => x > startIndex && x < endIndex).ToList();
            result.AddRange(secondList.Where(x => x > startIndex && x < endIndex).ToList());

            Console.WriteLine(string.Join(" ",result.OrderBy(x => x).ToList()));
        }
    }
}
