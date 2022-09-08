using System;
using System.Diagnostics;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numbers = new int[number];

            Result(number, numbers);
            
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void Result(int number, int[] numbers)
        {
            for (int i = 0; i < number; i++)
            {
                if (i == 0)
                {
                    numbers[i] = 1;
                }
                else if (i == 1)
                {
                    numbers[i] = numbers[i - 1];
                }
                else if (i == 2)
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2];
                }
                else
                {
                    numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
                }
            }
        }
    }
}
