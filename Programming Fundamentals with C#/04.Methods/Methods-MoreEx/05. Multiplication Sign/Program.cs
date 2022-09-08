using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Result(num1, num2, num3);
        }

        private static void Result(int num1, int num2, int num3)
        {
            int countOfNegative = 0;
            int countOfPositive = 0;
            int countOfZero = 0;
            int[] numbers = { num1, num2, num3 };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    countOfNegative++;
                }
                else if (numbers[i] > 0)
                {
                    countOfPositive++;
                }
                else
                {
                    countOfZero++;
                }
            }

            if (countOfZero > 0)
            {
                Console.WriteLine("zero");
            }
            else if (countOfPositive == 3 || countOfPositive == 1)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
}
