using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            //Dictionary<int, int> countOfNums = new Dictionary<int, int>();

            //foreach (var num in nums)
            //{
            //    if (!countOfNums.ContainsKey(num))
            //    {
            //        countOfNums.Add(num, 0);
            //    }
            //    countOfNums[num]++;
            //}

            //foreach (var count in countOfNums)
            //{
            //    Console.WriteLine($"{count.Key} -> {count.Value}");
            //}



            //List<string> input = Console.ReadLine().Split().ToList();
            //Dictionary<string, int> countOfInput = new Dictionary<string, int>();

            //foreach (var word in input)
            //{
            //    string currWord = word.ToLower();
            //    if (!countOfInput.ContainsKey(currWord))
            //    {
            //        countOfInput.Add(currWord, 0);
            //    }
            //    countOfInput[currWord]++;
            //}

            //foreach (var word in countOfInput)
            //{
            //    if (word.Value % 2 != 0)
            //    {
            //        Console.Write($"{word.Key} ");
            //    }
            //}


            //Dictionary<string, List<string>> wordCollections = new Dictionary<string, List<string>>();

            //int numberOfInputs = int.Parse(Console.ReadLine());
            //for (int i = 0; i < numberOfInputs; i++)
            //{
            //    string key = Console.ReadLine();
            //    string value = Console.ReadLine();
            //    if (!wordCollections.ContainsKey(key))
            //    {
            //        wordCollections.Add(key, new List<string>());
            //    }
            //    wordCollections[key].Add(value);
            //}

            //foreach (var word in wordCollections)
            //{
            //    Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            //}



            //string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();
            //foreach (var word in words)
            //{
            //    Console.WriteLine(string.Join(" ",word));
            //}

            char[] words = Console.ReadLine().ToCharArray();

            Dictionary<char, int> letters = new Dictionary<char, int>();

            foreach (var word in words)
            {
                if (word != ' ')
                {
                    if (!letters.ContainsKey(word))
                    {
                        letters[word] = 0;
                    }
                    letters[word]++;
                }
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
