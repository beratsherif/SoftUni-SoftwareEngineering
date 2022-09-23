using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int addCount = input[0];
            int elementsForDequeue = input[1];
            int elementForLook = input[2];

            Queue<int> stack = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));

            for (int i = 0; i < elementsForDequeue; i++)
            {
                stack.Dequeue();
            }

            if (stack.Contains(elementForLook))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
