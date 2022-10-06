using System;
using System.Collections.Generic;

namespace _08._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> VIP = new HashSet<string>();
            HashSet<string> regular = new HashSet<string>();

            bool check = false;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "PARTY")
                {
                    check = true;
                    continue;
                }

                if (input == "END")
                {
                    break;
                }

                if (check)
                {
                    char firstChar = input[0];
                    if (char.IsDigit(firstChar))
                    {
                        VIP.Remove(input);
                    }
                    else regular.Remove(input);
                }
                else
                {
                    char firstChar = input[0];
                    if (char.IsDigit(firstChar))
                    {
                        VIP.Add(input);
                    }
                    else regular.Add(input);
                }
            }

            int count = VIP.Count + regular.Count;

            Console.WriteLine(count);
            foreach (var people in VIP)
            {
                Console.WriteLine(people);
            }

            foreach (var people in regular)
            {
                Console.WriteLine(people);
            }
        }
    }
}
