using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> input = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());

            int boxesCounter = 1;
            int capacityCounter = capacity;
            while (input.Count > 0)
            {
                int currCount = input.Peek();
                if (currCount <= capacityCounter)
                {
                    capacityCounter -= currCount;
                    input.Pop();
                }
                else
                {
                    boxesCounter++;
                    capacityCounter = capacity;
                    capacityCounter -= currCount;
                    input.Pop();
                }
            }

            Console.WriteLine(boxesCounter);
        }
    }
}
