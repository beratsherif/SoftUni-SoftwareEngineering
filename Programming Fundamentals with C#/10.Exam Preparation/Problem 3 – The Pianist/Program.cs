using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> musicList = new Dictionary<string, List<string>>();

            int numberOfPieces = int.Parse(Console.ReadLine());

            //STEP-1
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string currPiece = input[0];
                string currComposer = input[1];
                string currKey = input[2];

                musicList[currPiece] = new List<string>() {"", ""};
                musicList[currPiece][0] = currComposer;
                musicList[currPiece][1] = currKey;
            }
            //STEP-2
            string cmd;
            while ((cmd = Console.ReadLine()) != "Stop")
            {
                string[] command = cmd.Split("|");

                string action = command[0];
                string piece = command[1];

                switch (action)
                {
                    case "Add":
                        Add(command, musicList, piece);
                        break;

                    case "Remove":
                        Remove(musicList, piece);
                        break;

                    case "ChangeKey":
                        ChangeKey(musicList, piece, command);
                        break;
                }
            }

            //STEP3
            foreach (var (piece, value) in musicList/*.OrderBy(x => x.Key).ThenBy(x =>x.Value[0])*/)
            {
                Console.WriteLine($"{piece} -> Composer: {value[0]}, Key: {value[1]}");
            }
        }

        private static void ChangeKey(Dictionary<string, List<string>> musicList, string piece, string[] command)
        {
            if (musicList.ContainsKey(piece))
            {
                string newKey = command[2];

                musicList[piece][1] = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void Remove(Dictionary<string, List<string>> musicList, string piece)
        {
            if (musicList.ContainsKey(piece))
            {
                musicList.Remove(piece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void Add(string[] command, Dictionary<string, List<string>> musicList, string piece)
        {
            string composerAdd = command[2];
            string keyAdd = command[3];

            if (musicList.ContainsKey(piece))
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            else
            {
                musicList[piece] = new List<string>() {"",""};
                musicList[piece][0] = composerAdd;
                musicList[piece][1] = keyAdd;
                Console.WriteLine($"{piece} by {composerAdd} in {keyAdd} added to the collection!");
            }
        }
    }
}
