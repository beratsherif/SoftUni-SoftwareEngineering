using System;

namespace _02._Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];
                if (currChar > firstChar && currChar < secondChar)
                {
                    result += currChar;
                }
            }

            Console.WriteLine(result);
        }
    }
}
