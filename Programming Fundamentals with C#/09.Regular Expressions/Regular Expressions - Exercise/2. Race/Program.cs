using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _2._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //pattern for finging names
            Regex patternForName = new Regex(@"(?<name>[A-Za-z])");

            //pattern for digits 
            string patternForDigits = @"(?<digits>\d+)";

            //variable sum of digits 
            int sumOfdigits = 0;

            //dictionary for participants
            Dictionary<string, int> participants = new Dictionary<string, int>();

            //list of names of participants 
            var names = Console.ReadLine().Split(", ").ToList();

            //reading the input after the names
            string input = Console.ReadLine();

            //Main logic for solving the problem
            while (input != "end of race")
            {
                //finding the names in array
                MatchCollection matchedNames = patternForName.Matches(input);
                //finding the digits in array
                MatchCollection matchedDigits = Regex.Matches(input, patternForDigits);

                string currName = string.Join("", matchedNames);
                string currDigits = string.Join("", matchedDigits);

                //Reset sum of digits 
                sumOfdigits = 0;
                for (int i = 0; i < currDigits.Length; i++)
                {
                    //Convert curr digit in integer 
                    sumOfdigits += int.Parse(currDigits[i].ToString());
                }

                //make a check if the participant existsin the list of names
                if (names.Contains(currName))
                {
                    //check if the participant name is not excisting in the dictionary
                    if (!participants.ContainsKey(currName))
                    {
                        //adding the curr name and sum of digits 
                        participants.Add(currName, sumOfdigits);
                    }
                    else
                    {
                        //updating the curr km of run
                        participants[currName] += sumOfdigits;
                    }
                }

                input = Console.ReadLine();
            }

            //Finding the winners
            var winners = participants.OrderByDescending(x => x.Value).Take(3);

            //Find the first place
            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);


            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");
            }
            foreach (var secondName in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }
            foreach (var thirdName in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdName.Key}");
            }
        }
    }
}
