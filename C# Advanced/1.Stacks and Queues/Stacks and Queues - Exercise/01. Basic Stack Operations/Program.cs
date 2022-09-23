using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int n = input[0];
            int removeTimes = input[1];
            int elementForLook = input[2];

            Stack<int> stack = new Stack<int>(Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            for (int i = 0; i < removeTimes; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(elementForLook))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(stack.Count);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
