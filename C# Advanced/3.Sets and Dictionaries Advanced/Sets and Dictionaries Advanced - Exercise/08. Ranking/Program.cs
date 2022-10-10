using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> studentsInformation =
                new SortedDictionary<string, Dictionary<string, int>>(); //information for student course and points;

            Dictionary<string, string> contestAndPasswords = new Dictionary<string, string>();

            while (true)//loop where we fill the contests and passwords
            {
                string[] input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of contests")
                {
                    break;
                }

                string contest = input[0];
                string passwordForContest = input[1];

                if (!contestAndPasswords.ContainsKey(contest))
                {
                    contestAndPasswords.Add(contest,passwordForContest);
                }
            }

            while (true)//the loop where we check the input and add points of students;
            {
                string[] input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of submissions")
                {
                    break;
                }

                string contest = input[0];
                string passwordForContest = input[1];
                string username = input[2];
                int points = int.Parse(input[3]);

                if (contestAndPasswords.ContainsKey(contest))
                {
                    if (contestAndPasswords[contest] == passwordForContest)
                    {
                        if (!studentsInformation.ContainsKey(username))
                        {
                            studentsInformation.Add(username,new Dictionary<string, int>());
                            studentsInformation[username].Add(contest,points);
                        }
                        else
                        {
                            if (!studentsInformation[username].ContainsKey(contest))
                            {
                                studentsInformation[username].Add(contest,points);
                            }
                            studentsInformation[username][contest] += points;
                        }
                    }
                }
            }

            string bestCandidate = studentsInformation.OrderByDescending(c => c.Value.Values.Sum()).First().Key;
            int bestCandidatePoints = studentsInformation[bestCandidate].Values.Sum();

            Console.WriteLine($"Best candidate is {bestCandidate} with total {bestCandidatePoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var candidate in studentsInformation)
            {
                var orderedByPoints = candidate.Value.OrderByDescending(c => c.Value);
                Console.WriteLine(candidate.Key);

                foreach (var contest in orderedByPoints)
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
