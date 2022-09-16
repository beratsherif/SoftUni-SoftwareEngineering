using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03._Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        { 
            List<int> key = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int currPos = 0;
            string regex = @"&(?<type>.+)&[^<]*<(?<coord>.+)>";
            string sequence;
            while ((sequence = Console.ReadLine()) != "find")
            {
                int keyLenght = key.Count;
                int sequenceLenght = sequence.Length;
                StringBuilder sb = new StringBuilder();

                for (int i = keyLenght; i < sequenceLenght; i++)
                {
                    key.Add(key[currPos]);
                    currPos++;
                }

                for (int i = 0; i < sequenceLenght; i++)
                {
                    sb.Append((char)(sequence[i] - key[i]));
                }

                Match m = Regex.Match(sb.ToString(), regex);

                if (m.Success)
                {
                    string type = m.Groups["type"].Value;
                    string coord = m.Groups["coord"].Value;
                    Console.WriteLine($"Found {type} at {coord}");
                }
            }
        }
    }
}
