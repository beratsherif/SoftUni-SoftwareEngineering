using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Dictionary<string, Dictionary<string, int>> allData = new Dictionary<string, Dictionary<string, int>>();
            //    Dictionary<string, int> playerScore = new Dictionary<string, int>();


            //    string input;
            //    while ((input = Console.ReadLine()) != "Season end")
            //    {
            //        if (input.Contains("->"))
            //        {
            //            string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            //            string player = cmd[0];
            //            string position = cmd[1];
            //            int skill = int.Parse(cmd[2]);

            //            if (!allData.ContainsKey(player))
            //            {
            //                allData.Add(player,new Dictionary<string, int> {{position,skill}});
            //                playerScore.Add(player,skill);

            //            }
            //            else
            //            {
            //                if (!allData[player].ContainsKey(position))
            //                {
            //                    //allData[player][position] = skill;
            //                    allData[player].Add(position,skill);
            //                    playerScore[player] += skill;
            //                }
            //                else
            //                {
            //                    if (allData[player][position] < skill)
            //                    {
            //                        playerScore[player] -= allData[player][position];
            //                        playerScore[player] += skill;

            //                        allData[player][position] = skill;// update skill value
            //                    }
            //                }
            //            }
            //        }//end of first version with ->
            //        else if (input.Contains("vs"))
            //        {
            //            string[] cmd = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

            //            string firstPlayer = cmd[0];
            //            string secondPlayer = cmd[1];

            //            if (allData.ContainsKey(firstPlayer) && allData.ContainsKey(secondPlayer))
            //            {
            //                for (int i = 0; i < allData[firstPlayer].Count; i++)
            //                {
            //                    if (allData[secondPlayer].ContainsKey(allData[firstPlayer].Keys.ElementAt(i)))
            //                    {
            //                        string currKey = allData[firstPlayer].Keys.ElementAt(i);

            //                        if (allData[firstPlayer][currKey] > allData[secondPlayer][currKey])
            //                        {
            //                            allData.Remove(secondPlayer);
            //                            playerScore.Remove(secondPlayer);
            //                            break;
            //                        }
            //                        if (allData[secondPlayer][currKey] > allData[firstPlayer][currKey])
            //                        {
            //                            allData.Remove(firstPlayer);
            //                            playerScore.Remove(firstPlayer);
            //                            break;
            //                        }
            //                    }
            //                }
            //            }
            //        }//end of second version with VS
            //    }//End of while loop

            //    foreach (var player in playerScore.OrderByDescending(x=>x.Value).ThenBy(x => x.Key))
            //    {
            //        Console.WriteLine($"{player.Key}: {player.Value} skill");

            //        for (int i = 0; i < allData[player.Key].Count; i++)
            //        {
            //            Console.WriteLine($"- {allData[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Key} <::> {allData[player.Key].OrderByDescending(x=> x.Value).ThenBy(x=>x.Key).ElementAt(i).Value}");
            //        }
            //}






            //SECOND VERSION WITH METHODS...
            Dictionary<string, Dictionary<string, int>> allData = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> playerScore = new Dictionary<string, int>();

            string input;
            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains(" -> "))
                {
                    AddingInformationInAllData(input, allData, playerScore);
                }
                else if (input.Contains(" vs "))
                {
                    Fighting(input, allData, playerScore);
                }
            }

            PrintingTheResult(allData, playerScore);
        }
        private static void PrintingTheResult(Dictionary<string, Dictionary<string, int>> allData, Dictionary<string, int> playerScore)
        {
            foreach (var player in playerScore.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");

                for (int i = 0; i < allData[player.Key].Count; i++)
                {
                    Console.WriteLine($"- {allData[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Key} <::> {allData[player.Key].OrderByDescending(x => x.Value).ThenBy(x => x.Key).ElementAt(i).Value}");
                }
            }
        }

        private static void Fighting(string input, Dictionary<string, Dictionary<string, int>> allData, Dictionary<string, int> playerScore)
        {
            string[] cmd = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);

            string firstPlayer = cmd[0];
            string secondPlayer = cmd[1];

            if (allData.ContainsKey(firstPlayer) && allData.ContainsKey(secondPlayer))
            {
                for (int i = 0; i < allData[firstPlayer].Count; i++)
                {
                    if (allData[secondPlayer].ContainsKey(allData[firstPlayer].Keys.ElementAt(i)))
                    {
                        string currKey = allData[firstPlayer].Keys.ElementAt(i);

                        if (allData[firstPlayer][currKey] > allData[secondPlayer][currKey])
                        {
                            allData.Remove(secondPlayer);
                            playerScore.Remove(secondPlayer);
                            break;
                        }
                        if (allData[secondPlayer][currKey] > allData[firstPlayer][currKey])
                        {
                            allData.Remove(firstPlayer);
                            playerScore.Remove(firstPlayer);
                            break;
                        }
                    }
                }
            }
        }

        private static void AddingInformationInAllData(string input, Dictionary<string, Dictionary<string, int>> allData, Dictionary<string, int> playerScore)
        {
            string[] cmd = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

            string player = cmd[0];
            string position = cmd[1];
            int skill = int.Parse(cmd[2]);

            if (!allData.ContainsKey(player))
            {
                allData.Add(player, new Dictionary<string, int> { { position, skill } });
                playerScore.Add(player, skill);

            }
            else
            {
                if (!allData[player].ContainsKey(position))
                {
                    //allData[player][position] = skill;
                    allData[player].Add(position, skill);
                    playerScore[player] += skill;
                }
                else
                {
                    if (allData[player][position] < skill)
                    {
                        playerScore[player] -= allData[player][position];
                        playerScore[player] += skill;

                        allData[player][position] = skill;// update skill value
                    }
                }
            }
        }
    }
}
