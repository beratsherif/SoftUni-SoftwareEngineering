using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rowsCount][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[input.Length];
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = input[col];
                }
            }

            while (true)
            {
                string[] cmd = Console.ReadLine().Split();
                if (cmd[0] == "END")
                {
                    break;
                }

                int rowCoordinate = int.Parse(cmd[1]);
                int colCoordineate = int.Parse(cmd[2]);
                int value = int.Parse(cmd[3]);
                if (rowCoordinate >= 0 && rowCoordinate < rowsCount && colCoordineate >= 0 &&
                    colCoordineate < jaggedArray[rowCoordinate].Length)
                {
                    switch (cmd[0])
                    {
                        case "Add":
                            jaggedArray[rowCoordinate][colCoordineate] += value;
                            break;
                        case "Subtract":
                            jaggedArray[rowCoordinate][colCoordineate] -= value;
                            break;
                    }
                }
                else
                    Console.WriteLine($"Invalid coordinates");
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]} ");
                }
                Console.WriteLine();
            }

            //foreach (var row in jaggedArray)
            //{
            //    Console.WriteLine(string.Join(" ",row));
            //}
        }
    }
}
