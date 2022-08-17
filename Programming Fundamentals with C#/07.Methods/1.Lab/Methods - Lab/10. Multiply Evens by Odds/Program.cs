using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));

            int evenSum = GetSumOfEvenDigits(input);
            int oddSum = GetSumOfOddDigits(input);
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);

            Console.WriteLine(result);

        }

        static int GetSumOfEvenDigits(int input)
        {
            int evenSum = 0;
            int currNumber = input;
            while (currNumber > 0)
            {
                int digit = currNumber % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                currNumber /= 10;
            }

            return evenSum;
        }

        static int GetSumOfOddDigits (int input)
        {
            int oddSum = 0;
            int currNumber = input;
            while (currNumber > 0)
            {
                int digit = currNumber % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                currNumber /= 10;
            }

            return oddSum;
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
