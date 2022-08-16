using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split(' ');
            string[] secondInput = Console.ReadLine().Split(' ');

            foreach (string input in firstInput)
            {
                for (int i = 0; i < secondInput.Length; i++)
                {
                    string currinput = secondInput[i];
                    if (input == currinput)
                    {
                        Console.Write($"{input} ");
                        break;
                    }
                }
            }
        }
    }
}
