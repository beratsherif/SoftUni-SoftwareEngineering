using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            int row = input[0];
            int col = input[1];

            int[,] matrix = new int[row, col];

            for (int rows = 0; rows < row; rows++)
            {
                int[] cmd = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => int.Parse(n))
                    .ToArray();
                for (int cols = 0; cols < col; cols++)
                {
                    matrix[rows, cols] = cmd[cols];
                }
            }

            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int i = 0; i < row - 2; i++)
            {
                for (int j = 0; j < col - 2; j++)
                {
                    int currSum =
                        matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        maxSumRow = i;
                        maxSumCol = j;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int i = maxSumRow; i < maxSumRow + 3; i++)
            {
                for (int j = maxSumCol; j < maxSumCol + 3; j++)
                {
                    Console.Write($"{matrix[i,j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
