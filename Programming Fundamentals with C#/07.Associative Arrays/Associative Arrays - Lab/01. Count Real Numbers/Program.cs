using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> ocurencesByNumber = new SortedDictionary<double, int>();

            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            foreach (var number in numbers)
            {
                if (!ocurencesByNumber.ContainsKey(number))
                {
                    ocurencesByNumber.Add(number, 0);
                }

                ocurencesByNumber[number]++;
            }

            foreach (var ocurenceByNumber in ocurencesByNumber)
            {
                Console.WriteLine($"{ocurenceByNumber.Key} -> {ocurenceByNumber.Value}");
            }
        }
    }
}
