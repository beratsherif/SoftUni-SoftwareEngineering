using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElem_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(n => int.Parse(n)).ToArray();

            int nFistSetLenght = input[0];
            int mSecondSetLenght = input[1];

            HashSet<int> firstSet = new HashSet<int>(nFistSetLenght);
            HashSet<int> secondSet = new HashSet<int>(mSecondSetLenght);

            for (int i = 0; i < nFistSetLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < mSecondSetLenght; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            firstSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(' ',firstSet));
        }
    }
}
