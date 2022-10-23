using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action<int, HashSet<int>> printTheResult = (endOfRange, dividers) =>
            //{
            //    for (int i = 1; i <= endOfRange; i++)
            //    {
            //        int curNum = i;
            //        bool check = true;
            //        foreach (var divider in dividers)
            //        {
            //            if (i % divider != 0)
            //            {
            //                check = false;
            //                break;
            //            }
            //        }

            //        if (check)
            //        {
            //            Console.Write($"{i} ");
            //        }
            //    }
            //};

            //int endOfRange = int.Parse(Console.ReadLine());
            //HashSet<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToHashSet();

            //printTheResult(endOfRange, dividers);



            List<Predicate<int>> predicates = new List<Predicate<int>>();

            int endRange = int.Parse(Console.ReadLine());

            HashSet<int> dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            int[] numbers = Enumerable.Range(1, endRange).ToArray();

            foreach (var divider in dividers)
            {
                predicates.Add(p => p % divider == 0);
            }

            foreach (var number in numbers)
            {
                bool isDivisible = true;

                foreach (var match in predicates)
                {
                    if (!match(number))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
