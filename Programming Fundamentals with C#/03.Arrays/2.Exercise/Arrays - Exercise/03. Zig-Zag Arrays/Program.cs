using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] evenNums = new int[n];
            int[] oddnums = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    evenNums[i] = currInput[0];
                    oddnums[i] = currInput[1];
                }
                else
                {
                    oddnums[i] = currInput[0];
                    evenNums[i] = currInput[1];
                }
            }
            Console.WriteLine(string.Join(" ", evenNums));
            Console.WriteLine(string.Join(" ", oddnums));
        }
    }
}
