using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //List<string> words = new List<string>();
            //while (true)
            //{
            //    string input = Console.ReadLine();
            //    if (input == "end")
            //    {
            //        break;
            //    }
            //    words.Add(input);
            //}

            //foreach (var word in words)
            //{
            //    string reverserd = string.Empty;
            //    for (int i = word.Length - 1; i >= 0; i--)
            //    {
            //        reverserd += word[i];
            //    }
            //    Console.WriteLine($"{word} = {reverserd}");
            //}

            //2
            //while (true)
            //{
            //    string input = Console.ReadLine();

            //    if (input == "end")
            //    {
            //        break;
            //    }

            //    string reversedInput = string.Join("", input.ToCharArray().Reverse());

            //    Console.WriteLine($"{input} = {reversedInput}");
            //}


            //3
            string input = Console.ReadLine();

            while (input != "end")
            {
                string reversedInput = string.Join("", input.ToCharArray().Reverse());
                Console.WriteLine($"{input} = {reversedInput}");

                input = Console.ReadLine();
            }

        }
    }
}
