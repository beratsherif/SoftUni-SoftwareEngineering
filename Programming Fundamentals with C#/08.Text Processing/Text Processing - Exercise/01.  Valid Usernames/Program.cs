using System;
using System.Collections.Generic;

namespace _01.__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            foreach (var username in input)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool check = true;
                    for (int i = 0; i < username.Length; i++)
                    {
                        if (!(username[i] == '-' || username[i] == '_' || char.IsLetter(username[i]) || char.IsDigit(username[i])))
                        {
                            check = false;
                            break;
                        }
                    }
                    if (check)
                    {
                        validUsernames.Add(username);
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, validUsernames));
        }

    }
}
