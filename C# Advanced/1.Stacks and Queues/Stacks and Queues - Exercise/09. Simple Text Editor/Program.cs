using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> memory = new Stack<string>();
            StringBuilder text = new StringBuilder();
            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string cmd = input[0];
                switch (cmd)
                {
                    case "1":
                        string someText = input[1];
                        text.Append(someText);
                        memory.Push(text.ToString());
                        break;

                    case "2":
                        int countForErase = int.Parse(input[1]);
                        text = text.Remove(text.Length - countForErase, countForErase);
                        memory.Push(text.ToString());
                        break;

                    case "3":
                        int index = int.Parse(input[1]);
                        if (index >= 0 && index <= text.Length)
                        {
                            Console.WriteLine(text[index - 1]);
                        }
                        break;

                    case "4":
                        memory.Pop();
                        if (memory.Count > 0)
                        {
                            string previousVersion = memory.Peek();
                            text = new StringBuilder(previousVersion);
                        }
                        else
                            text = new StringBuilder();
                        break;
                }
            }
        }
    }
}
