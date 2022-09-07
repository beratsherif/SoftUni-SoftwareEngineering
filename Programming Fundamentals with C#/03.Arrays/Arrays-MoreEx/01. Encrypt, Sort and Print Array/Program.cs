using System;
using System.Linq;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] results = new int[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                char[] currInput = input.ToCharArray();

                foreach (var currChar in currInput)
                {
                    if (currChar == 'a' || currChar == 'o' || currChar == 'e' || currChar == 'i' || currChar == 'u' || currChar == 'A' || currChar == 'O' || currChar == 'E' || currChar == 'I' || currChar == 'U')
                    {
                        sum += currChar * currInput.Length;
                    }
                    else
                    {
                        sum += currChar / currInput.Length;
                    }
                }

                results[i] = sum;
            }

            results = results.OrderByDescending(c => c).Reverse().ToArray();
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }
    }
}
