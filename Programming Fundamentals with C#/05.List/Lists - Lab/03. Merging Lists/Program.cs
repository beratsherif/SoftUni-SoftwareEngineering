using System;
using System.Linq;
using System.Collections.Generic;
namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> SecondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int max = Math.Max(firstList.Count, SecondList.Count);

            List<int> orList = new List<int>(firstList.Count + SecondList.Count);

            for (int i = 0; i < max; i++)
            {
                if (firstList.Count > i)
                {
                    orList.Add(firstList[i]);
                }
                if (SecondList.Count > i)
                {
                    orList.Add(SecondList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", orList));
        }
    }
}
