using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> conterstsAndPassword = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> allSubmissions = new Dictionary<string, Dictionary<string, int>>();

            string con;
            while ((con = Console.ReadLine()) != "end of contests")
            {
                string[] contests = con.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string currContest = contests[0];
                string currContestPass = contests[1];
                conterstsAndPassword.Add(currContest, currContestPass);
            }

            string sub;
            while ((sub = Console.ReadLine()) != "end of submissions")
            {
                string[] submissions = sub.Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string contest = submissions[0];
                string password = submissions[1];
                string username = submissions[2];
                int points = int.Parse(submissions[3]);

                if (conterstsAndPassword.ContainsKey(contest) && conterstsAndPassword[contest] == password)
                {
                    if (!allSubmissions.ContainsKey(username))
                    {
                        allSubmissions[username] = new Dictionary<string, int>();
                    }

                    if (allSubmissions.ContainsKey(username) && !allSubmissions[username].ContainsKey(contest))
                    {
                        allSubmissions[username][contest] = 0;
                    }

                    if (allSubmissions[username][contest] < points)
                    {
                        allSubmissions[username][contest] = points;
                    }
                }
            }

            string winner = allSubmissions.OrderBy(x => x.Value.Values.Sum()).Last().Key;
            int bestPoints = allSubmissions.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {bestPoints} points.");

            Console.WriteLine($"Ranking:");

            foreach (var item in allSubmissions.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
