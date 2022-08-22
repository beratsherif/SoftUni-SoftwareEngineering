using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {

                string[] commands = Console.ReadLine().Split();
                string command = commands[0];

                if (command == "3:1") break;

                int startingIndex = int.Parse(commands[1]);
                int endingIndex = int.Parse(commands[2]);
                string concatedWord = "";

                if (endingIndex > myList.Count - 1 || endingIndex < 0)
                {
                    endingIndex = myList.Count - 1;
                }

                if (startingIndex < 0 || startingIndex > myList.Count - 1)
                {
                    startingIndex = 0;
                }


                if (command == "merge")
                {
                    for (int i = startingIndex; i <= endingIndex; i++)
                    {
                        concatedWord += myList[i];
                    }

                    myList.RemoveRange(startingIndex, endingIndex - startingIndex + 1);
                    myList.Insert(startingIndex, concatedWord);
                }
                else if (command == "divide")
                {
                    var dividedList = new List<string>();
                    int partitions = int.Parse(commands[2]);
                    string word = myList[startingIndex];
                    myList.RemoveAt(startingIndex);
                    int parts = word.Length / partitions;

                    for (int i = 0; i < partitions; i++)
                    {
                        if (i == partitions - 1)
                        {
                            dividedList.Add(word.Substring(i * parts));
                        }
                        else
                        {
                            dividedList.Add(word.Substring(i * parts, parts));
                        }
                    }

                    myList.InsertRange(startingIndex, dividedList);
                }
            }

            Console.WriteLine(string.Join(" ",myList));
        }
    }
}
