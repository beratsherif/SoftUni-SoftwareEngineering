using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> users = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] info = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string username = info[0];
                string contest = info[1];
                int points = int.Parse(info[2]);

                if (!contests.ContainsKey(contest))
                {
                    contests.Add(contest, new Dictionary<string, int>());
                    contests[contest][username] = points;
                }
                else
                {
                    if (!contests[contest].ContainsKey(username))
                    {
                        contests[contest][username] = points;
                    }
                    else
                    {
                        if (contests[contest][username] < points)
                        {
                            contests[contest][username] = points;
                        }
                    }
                }
            }//end of while loop

            foreach (var contest in contests)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int counter = 0;


                foreach (var name in contest.Value.OrderByDescending(x => x.Value).ThenBy(x=> x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {name.Key} <::> {name.Value}");
                }

                counter = 0;
            }//foreach end

            Console.WriteLine("Individual standings:");

            foreach (var contest in contests)
            {
                foreach (var name in contest.Value)
                {
                    if (!users.ContainsKey(name.Key))
                    {
                        users.Add(name.Key,name.Value);
                    }
                    else
                    {
                        users[name.Key] = users[name.Key] + name.Value;
                    }
                }
            }//foreach end

            int counter1 = 0;
            foreach (var name in users.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter1++;
                Console.WriteLine($"{counter1}. {name.Key} -> {name.Value}");
            }
        }
    }
}
