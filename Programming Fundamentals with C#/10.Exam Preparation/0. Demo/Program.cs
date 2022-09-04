using System;
using System.Collections.Generic;

namespace _0._Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, KeyValuePair<string, string>> musicList = new Dictionary<string, KeyValuePair<string, string>>();

            int numberOfPieces = int.Parse(Console.ReadLine());

            //STEP-1
            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] input = Console.ReadLine().Split("|");

                string currPiece = input[0];
                string currcomposer = input[1];
                string currKey = input[2];

                musicList[currPiece] = new KeyValuePair<string, string>(currcomposer, currKey);
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

            //STEP-3
            foreach (var (piece, value) in musicList)
            {
                Console.WriteLine($"{piece} -> Composer: {value.Key}, Key: {value.Value}");
            }

            //ITH FURTHER LIST FUNCTION IN THE BEGGINING WE CAN DO THIS WAY
            //foreach (var piece in furtherListOnlyForMusicList)
            //{
            //    Console.WriteLine($"{piece} -> Composer: {musicList[piece].Key}, Key: {musicList[piece].Value}");
            //}
        }

        private static void ChangeKey(Dictionary<string, KeyValuePair<string, string>> musicList, string piece, string[] command)
        {
            if (musicList.ContainsKey(piece))
            {
                string newKey = command[2];

                var pieceData = musicList[piece];
                var composer = pieceData.Key;
                musicList[piece] = new KeyValuePair<string, string>(composer, newKey);
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void Remove(Dictionary<string, KeyValuePair<string, string>> musicList, string piece)
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

        private static void Add(string[] command, Dictionary<string, KeyValuePair<string, string>> musicList, string piece)
        {
            string composerAdd = command[2];
            string keyAdd = command[3];

            if (musicList.ContainsKey(piece))
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            else
            {
                musicList[piece] = new KeyValuePair<string, string>(composerAdd, keyAdd);
                Console.WriteLine($"{piece} by {composerAdd} in {keyAdd} added to the collection!");
            }
        }
    }
}
