using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            string input = Console.ReadLine().ToLower();

            //Console.WriteLine(CountOfVowels(input));
            CountOfVowels(input);
        }

        //static int CountOfVowels(string input)
        //{
        //    int count = 0;

        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        switch (input[i])
        //        {
        //            case 'A':
        //            case 'a':
        //            case 'E':
        //            case 'e':
        //            case 'I':
        //            case 'i':
        //            case 'O':
        //            case 'o':
        //            case 'U':
        //            case 'u':
        //                count++;
        //                break;
        //        }
        //    }

        //    return count;
        //}


        static void CountOfVowels(string input)
        {
            Console.WriteLine(input.Count(vowles => "aouei".Contains(vowles)));
        }
    }
}
