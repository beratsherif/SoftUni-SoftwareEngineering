using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int cmd = input[0];
                switch (cmd)
                {
                    case 1:
                        AddElement(input, stack);
                        break;
                    case 2:
                        RemoveElement(stack);
                        break;
                    case 3:
                        MaxElement(stack);
                        break;
                    case 4:
                        MinElement(stack);
                        break;

                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
        static void AddElement(int[] input, Stack<int> stack)
        {
            int elementForPush = input[1];
            stack.Push(elementForPush);
        }
        static void RemoveElement(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                stack.Pop();
            }
        }
        static void MinElement(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int minElement = stack.Min();
                Console.WriteLine(minElement);
            }
        }
        static void MaxElement(Stack<int> stack)
        {
            if (stack.Count > 0)
            {
                int maxElement = stack.Max();
                Console.WriteLine(maxElement);
            }
        }
        
    }
}
