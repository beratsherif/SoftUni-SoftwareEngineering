using System;

namespace Problem_1___Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();

            string cmd;
            while ((cmd = Console.ReadLine()) != "Generate")
            {
                string[] command = cmd.Split(">>>");

                string action = command[0];
                switch (action)
                {
                    case "Contains":
                        Contains(command, key);
                        break;

                    case "Flip":
                        key = Flip(command, key);
                        break;

                    case "Slice":
                        key = Slice(command, key);
                        break;
                }
            }

            Console.WriteLine($"Your activation key is: {key}");
        }

        static string Slice(string[] command, string key)
        {
            int startIndex = int.Parse(command[1]);
            int endIndex = int.Parse(command[2]);

            key = key.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(key);

            return key;
        }

        static string Flip(string[] command, string key)
        {
            string upperOrLower = command[1];
            int startIndex = int.Parse(command[2]);
            int endIndex = int.Parse(command[3]);

            string originalSubstring = key.Substring(startIndex, endIndex - startIndex);
            string newSubstring = originalSubstring.ToLower();

            if (upperOrLower == "Upper")
            {
                newSubstring = newSubstring.ToUpper();
            }

            key = key.Replace(originalSubstring, newSubstring);

            Console.WriteLine(key);

            return key;
        }

        private static void Contains(string[] command, string key)
        {
            string substring = command[1];
            if (key.Contains(substring))
            {
                Console.WriteLine($"{key} contains {substring}");
            }
            else
            {
                Console.WriteLine("Substring not found!");
            }
        }
    }
}
