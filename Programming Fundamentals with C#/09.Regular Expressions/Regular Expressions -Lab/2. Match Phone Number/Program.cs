using System;
using System.Text.RegularExpressions;

namespace _2._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359(?<sep>[ \-])2(\k<sep>)([0-9]{3})(\k<sep>)([0-9]{4})\b";

            MatchCollection matches = Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
