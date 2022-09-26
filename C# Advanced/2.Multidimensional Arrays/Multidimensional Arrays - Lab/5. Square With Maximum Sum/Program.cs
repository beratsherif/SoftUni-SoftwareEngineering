using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] colInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = colInput[j];
                }
            }

            int[,] biggestMatrix = new int[2, 2];
            int biggestMatrixValue = 0;

            for (int i = 0; i < row - 1; i++)
            {
                for (int j = 0; j < col - 1; j++)
                {
                    int currMatrixRes = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (currMatrixRes > biggestMatrixValue)
                    {
                        biggestMatrix[0, 0] = matrix[i, j];
                        biggestMatrix[0, 1] = matrix[i, j + 1];
                        biggestMatrix[1, 0] = matrix[i + 1, j];
                        biggestMatrix[1, 1] = matrix[i + 1, j + 1];
                        biggestMatrixValue = currMatrixRes;
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{biggestMatrix[i,j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(biggestMatrixValue);
        }
    }
}
