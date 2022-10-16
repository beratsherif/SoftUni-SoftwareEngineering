using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;
                int counter = 0;

                while (line != null)
                {
                    line = reader.ReadLine();

                    if (counter % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string reverseWords = ReverseWords(replacedSymbols);
                        sb.AppendLine(reverseWords);
                    }

                    counter++;
                }
            }

            return sb.ToString().TrimEnd();
        }

        private static string ReplaceSymbols(string line)
        {
            string[] symbolsToReplace = { "-", ",", ".", "!", "?" };
            foreach (var symbol in symbolsToReplace)
            {
                line = line.Replace(symbol, "@");
            }

            return line;
        }

        private static string ReverseWords(string replacedSymbols)
        {
            string[] reversedWords = replacedSymbols
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Reverse()
                .ToArray();

            return string.Join(" ", reversedWords);
        }

    }
}
