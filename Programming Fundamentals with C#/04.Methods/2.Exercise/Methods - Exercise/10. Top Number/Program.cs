using System;
namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            IsNumberIsTopNumber(input);
        }

        private static void IsNumberIsTopNumber(int input)
        {
            for (int i = 1; i < input; i++)
            {
                if (IsHasOneOddDigit(i) && IsDigitsSumDividibleBy8(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsDigitsSumDividibleBy8(int input)
        {
            int digitSum = 0;

            while (input > 0)
            {
                digitSum += input % 10;
                input /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }

            return false;
        }

        private static bool IsHasOneOddDigit(int input)
        {
            while (input > 0)
            {
                if ((input % 10) % 2 == 1)
                {
                    return true;

                }
                    input /= 10;
            }
                return false;
        }
    }
}
