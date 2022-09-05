using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Problem_2___Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string emojiPattern = @"(:{2}|\*{2})(?<emoji>[A-Z]{1}[a-z]{2,})\1";
            string numPattern = @"\d";

            MatchCollection emojies = Regex.Matches(input, emojiPattern);
            MatchCollection numbers = Regex.Matches(input, numPattern);

            long coolThreshold = 1;
            foreach (Match num in numbers)
            {
                coolThreshold *= int.Parse(num.Value);
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojies.Count} emojis found in the text. The cool ones are:");

            foreach (Match emojy in emojies)
            {
                string emoji = emojy.Groups["emoji"].Value;
                long emojiThreshold = emoji.ToCharArray().Sum(c => c);

                if (emojiThreshold >= coolThreshold)
                {
                    Console.WriteLine(emojy);
                }
            }
        }
    }
}
