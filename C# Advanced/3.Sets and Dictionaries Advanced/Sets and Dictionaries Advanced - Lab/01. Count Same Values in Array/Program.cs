using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(n => double.Parse(n)).ToArray();

            Dictionary<double, int> counter = new Dictionary<double, int>();
            foreach (var number in numbers)
            {
                if (!counter.ContainsKey(number))
                {
                    counter.Add(number,0);
                }

                counter[number]++;
            }

            foreach (var count in counter)
            {
                Console.WriteLine($"{count.Key} - {count.Value} times");
            }
        }
    }
}
