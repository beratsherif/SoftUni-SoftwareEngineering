using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] input = Console.ReadLine()
            //    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .ToArray();
            //Queue<int> queue = new Queue<int>(input);
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse));
            Queue<int> evenNums = new Queue<int>();

            while (queue.Count > 0)
            {
                int currNum = queue.Dequeue();
                if (currNum % 2 == 0)
                {
                    evenNums.Enqueue(currNum);
                }
            }
            Console.WriteLine(string.Join(", ", evenNums));
        }
    }
}
