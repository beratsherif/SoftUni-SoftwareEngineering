using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTabl
{
    class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> set = new HashSet<string>();

            //int inputCount = int.Parse(Console.ReadLine());
            //for (int i = 0; i < inputCount; i++)
            //{
            //    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //    set.UnionWith(input);
            //}

            //Console.WriteLine(string.Join(' ',set.OrderBy(p => p)));

            SortedSet<string> sortedSet = new SortedSet<string>();

            int inputCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                sortedSet.UnionWith(input);
            }
            Console.WriteLine(string.Join(' ', sortedSet));
        }
    }
}
