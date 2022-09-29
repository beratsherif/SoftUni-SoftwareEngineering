using System;
using System.Linq;

namespace _4._Matrix_Shuffling
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

            string[,] matrix = new string[row, col];

            for (int rows = 0; rows < row; rows++)
            {
                string[] dimensions = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int cols = 0; cols < col; cols++)
                {
                    matrix[rows, cols] = dimensions[cols];
                }
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split();

                if (cmd[0] == "END")
                {
                    return;
                }
                else
                {
                    if (cmd[0] == "swap" &&
                        cmd.Length == 5 &&
                        int.Parse(cmd[1]) >= 0 && int.Parse(cmd[1]) < row &&
                        int.Parse(cmd[2]) >= 0 && int.Parse(cmd[2]) < col &&
                        int.Parse(cmd[3]) >= 0 && int.Parse(cmd[3]) < row &&
                        int.Parse(cmd[4]) >= 0 && int.Parse(cmd[4]) < col)
                    {
                        int row1 = int.Parse(cmd[1]);
                        int col1 = int.Parse(cmd[2]);
                        int row2 = int.Parse(cmd[3]);
                        int col2 = int.Parse(cmd[4]);

                        string swaping1Value = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = swaping1Value;

                        for (int i = 0; i < row; i++)
                        {
                            for (int j = 0; j < col; j++)
                            {
                                Console.Write($"{matrix[i,j]} ");
                            }

                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
            }
        }
    }
}
