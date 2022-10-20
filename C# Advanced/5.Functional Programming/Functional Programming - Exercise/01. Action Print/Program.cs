using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> printing = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));

            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            printing(input);
        }
    }
}
