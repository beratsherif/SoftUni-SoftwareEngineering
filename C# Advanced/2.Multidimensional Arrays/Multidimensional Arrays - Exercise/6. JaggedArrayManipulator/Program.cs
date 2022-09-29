using System;
using System.Linq;

namespace _6._JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jagged = new int[n][];

            for (int i = 0; i < jagged.Length; i++)
            {
                int[] cols = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .Select(n =>int.Parse(n))
                    .ToArray();
                jagged[i] = cols;
            }

            for (int row = 0; row < jagged.Length - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }

                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmd[0] == "End")
                {
                    break;
                }
                else
                {

                    int row = int.Parse(cmd[1]);
                    int col = int.Parse(cmd[2]);
                    int value = int.Parse(cmd[3]);

                    switch (cmd[0])
                    {
                        case "Add":
                            if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                            {
                                jagged[row][col] += value;
                            }
                            break;
                        case "Subtract":
                            if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                            {
                                jagged[row][col] -= value;
                            }
                            break;
                    }
                }
            }

            for (int r = 0; r < jagged.Length; r++)
            {
                for (int c = 0; c < jagged[r].Length; c++)
                {
                    Console.Write($"{jagged[r][c]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
