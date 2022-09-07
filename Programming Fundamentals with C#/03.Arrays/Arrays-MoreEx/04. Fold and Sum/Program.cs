using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();

            int firstAndLastNumbersLenght = numbers.Length / 4;

            int[] result = new int[firstAndLastNumbersLenght * 2];


            for (int i = 0; i < firstAndLastNumbersLenght; i++)
            {
                result[i] = numbers[i + firstAndLastNumbersLenght] + numbers[firstAndLastNumbersLenght - 1 - i];

                result[i + firstAndLastNumbersLenght] =
                    numbers[i + 2 * firstAndLastNumbersLenght] + numbers[numbers.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
