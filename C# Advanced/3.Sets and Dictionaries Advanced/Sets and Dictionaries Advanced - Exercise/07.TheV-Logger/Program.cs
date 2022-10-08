using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Vlogger> vloggers = new HashSet<Vlogger>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Statistics")
                {
                    break;
                }

                string vloggerName = input[0];
                string action = input[1];
                string vloggerToFollow = input[2];

                if (action == "joined")
                {
                    if (!vloggers.Any(v => v.Name == vloggerName))
                    {
                        vloggers.Add(new Vlogger(vloggerName));
                    }
                }
                else
                {
                    if (vloggerName == vloggerToFollow
                        || !vloggers.Any(v => v.Name == vloggerName)
                        || !vloggers.Any(v => v.Name == vloggerToFollow))
                    {
                        continue;
                    }

                    Vlogger vlogger = vloggers.Single(v => v.Name == vloggerName);
                    vlogger.Following.Add(vloggerToFollow);

                    Vlogger vloggerToFollowName = vloggers.Single(v => v.Name == vloggerToFollow);
                    vloggerToFollowName.Followers.Add(vloggerName);
                }
            }

            vloggers = vloggers.OrderByDescending(v => v.Followers.Count).ThenBy(v => v.Following.Count).ToHashSet();

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;

            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");
                if (count == 1)
                {
                    foreach (var follower in vlogger.Followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }

    public class Vlogger
    {
        public Vlogger(string name)
        {
            this.Name = name;
            this.Followers = new SortedSet<string>();
            this.Following = new HashSet<string>();
        }
        public string Name { get; set; }
        public SortedSet<string> Followers { get; set; }
        public HashSet<string> Following { get; set; }
    }
}
