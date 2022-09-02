using System;
using System.Text.RegularExpressions;

namespace _3._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<day>\d{2})(?<separator>[-.\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>\d{4})\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}
