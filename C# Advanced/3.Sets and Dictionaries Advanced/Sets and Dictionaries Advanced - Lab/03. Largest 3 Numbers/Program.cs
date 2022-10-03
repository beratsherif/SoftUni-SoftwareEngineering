using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();
            int[] sortedArray = input.OrderByDescending(n => n).ToArray();

            int counter = 3;
            if (sortedArray.Length < 3)
            {
                counter = sortedArray.Length;
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{sortedArray[i]} ");
            }
        }
    }
}
