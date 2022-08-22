using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerCards.Count > 0 && secondPlayerCards.Count > 0)
            {
                if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.Add(secondPlayerCards[0]);
                }
                else if (secondPlayerCards[0] > firstPlayerCards[0])
                {
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    secondPlayerCards.Add(firstPlayerCards[0]);
                }

                firstPlayerCards.Remove(firstPlayerCards[0]);
                secondPlayerCards.Remove(secondPlayerCards[0]);

                if (firstPlayerCards.Count == 0)
                {
                    int secondPlayerSum = secondPlayerCards.Sum();
                    Console.WriteLine($"Second player wins! Sum: {secondPlayerSum}");
                    break;
                }

                if (secondPlayerCards.Count == 0)
                {
                    int firstPlayerSum = firstPlayerCards.Sum();
                    Console.WriteLine($"First player wins! Sum: {firstPlayerSum}");
                    break;
                }
            }
        }
    }
}
