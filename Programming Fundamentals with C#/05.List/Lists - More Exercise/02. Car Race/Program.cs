using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            double leftPlayer = LeftPlayerCalculation(numbers);
            double rightPlayer = RightPlayerCalculation(numbers);

            PrintingResult(leftPlayer, rightPlayer);
        }

        private static double LeftPlayerCalculation(List<int> numbers)
        {
            double result = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                result += numbers[i];

                if (numbers[i] == 0)
                {
                    result *= 0.8;
                }
            }

            return result;
        }

        private static double RightPlayerCalculation(List<int> numbers)
        {
            double result = 0;

            for (int i = numbers.Count - 1; i > numbers.Count / 2; i--)
            {
                result += numbers[i];

                if (numbers[i] == 0)
                {
                    result *= 0.8;
                }
            }

            return result;
        }

        private static void PrintingResult(double leftPlayer, double rightPlayer)
        {
            if (leftPlayer < rightPlayer)
            {
                Console.WriteLine($"The winner is left with total time: {leftPlayer}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightPlayer}");
            }
        }
    }
}
