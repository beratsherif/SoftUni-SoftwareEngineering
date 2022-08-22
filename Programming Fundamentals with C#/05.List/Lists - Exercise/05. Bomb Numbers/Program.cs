using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> specialNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            int start = bombNumbers[0];
            int power = bombNumbers[1];

            for (int i = 0; i < specialNumbers.Count; i++)
            {
                int targetNum = specialNumbers[i];

                if (targetNum == start)
                {
                    BombNumbers(specialNumbers, power, i);
                }
            }


            Console.WriteLine(specialNumbers.Sum());
        }

        private static void BombNumbers(List<int> numbers, int power, int i)
        {
            int startingIndex = Math.Max(0, i - power);
            int end = Math.Min(numbers.Count - 1, i + power);

            for (int j = startingIndex; j <= end; j++)
            {
                numbers[j] = 0;
            }
        }
    }
}
