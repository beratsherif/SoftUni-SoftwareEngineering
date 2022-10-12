using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            SortedDictionary<string, int> counter = new SortedDictionary<string, int>();
            string text = File.ReadAllText(wordsFilePath);
            string[] words = text.Split();
            using (StreamReader reader = new StreamReader(textFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string curLine = reader.ReadLine();
                    while (curLine != null)
                    {
                        foreach (var word in words)
                        {
                            if (curLine.ToLower().Contains(word))
                            {
                                if (!counter.ContainsKey(word))
                                {
                                    counter.Add(word,0);
                                }

                                counter[word]++;
                            }
                        }

                        curLine = reader.ReadLine();
                    }

                    foreach (var word in counter.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
        }
    }

}