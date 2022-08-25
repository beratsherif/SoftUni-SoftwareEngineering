using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] words = Console.ReadLine().Split();
            //Dictionary<string, int> counts = new Dictionary<string, int>();

            //foreach (var word in words)
            //{
            //    string wordInLowerCase = word.ToLower();
            //    if (counts.ContainsKey(wordInLowerCase))
            //    {
            //        counts[wordInLowerCase]++;
            //    }
            //    else
            //    {
            //        counts.Add(wordInLowerCase, 1);
            //    }
            //}

            //foreach (var count in counts)
            //{
            //    if (count.Value % 2 != 0)
            //    {
            //        Console.WriteLine(count.Key + " ");
            //    }
            //}


            Dictionary<string, int> wordsCounts = new Dictionary<string, int>();

            string[] words = Console.ReadLine().Split().Select(word => word.ToLower()).ToArray();

            foreach (var word in words)
            {
                if (!wordsCounts.ContainsKey(word))
                {
                    wordsCounts.Add(word, 0);
                }

                wordsCounts[word]++;
            }
            
            string[] oddCountWords = wordsCounts.Where(w => w.Value % 2 != 0).Select(w => w.Key).ToArray();
            Console.WriteLine(string.Join(" ", oddCountWords));
        }
    }
}
