using System;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());

            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colsValues = Console.ReadLine().Split();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(colsValues[col]);
                }
            }

            int leftToRight = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j <= i; j++)
                {
                    leftToRight += matrix[i, j];
                }
            }

            int rightToLeft = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1 - i; j >= matrix.GetLength(1) - 1 - i; j--)
                {
                    rightToLeft += matrix[i, j];
                }
            }

            int diff = Math.Abs(leftToRight - rightToLeft);
            Console.WriteLine(diff);
        }
    }
}
