using System;
using System.Linq;

namespace Problem_1___Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Reveal")
            {
                string[] currCommand = cmd.Split(":|:");

                switch (currCommand[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(currCommand[1]);

                        input = input.Insert(index, " ");
                        break;
                    case "Reverse":
                        string substring = currCommand[1];

                        if (input.Contains(substring))
                        {
                            int substringIndex = input.IndexOf(substring);

                            input = input.Remove(substringIndex, substring.Length);
                            input = input + string.Join("", substring.Reverse());
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string curSubstring = currCommand[1];
                        string replacement = currCommand[2];

                        if (input.Contains(curSubstring))
                        {
                            input = input.Replace(curSubstring, replacement);
                        }
                        break;
                }

                Console.WriteLine(input);
            }

            Console.WriteLine($"You have a new text message: {input}");
        }
    }
}
