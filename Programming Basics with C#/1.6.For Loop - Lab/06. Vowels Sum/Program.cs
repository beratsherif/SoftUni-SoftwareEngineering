using System;

namespace _06._Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                switch (letter)
                {
                    case 'a':
                        total += 1;
                        break;
                    case 'e':
                        total += 2;
                        break;
                    case 'i':
                        total += 3;
                        break;
                    case 'o':
                        total += 4;
                        break;
                    case 'u':
                        total += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(total);
        }
    }
}
