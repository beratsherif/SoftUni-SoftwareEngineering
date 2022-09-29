using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                char[] colInput = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => char.Parse(n))
                    .ToArray();

                for (int col = 0; col < size[1]; col++)
                {
                    matrix[row, col] = colInput[col];
                }
            }

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1) - 1; col++)
                {
                    if (matrix[row,col] == matrix[row,col + 1]
                        && matrix[row, col] == matrix[row + 1, col]
                        && matrix[row,col] == matrix[row + 1,col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
