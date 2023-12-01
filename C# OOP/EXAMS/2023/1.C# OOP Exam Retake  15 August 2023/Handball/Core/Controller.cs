namespace Handball.Core
{
    using Handball.Core.Contracts;
    using Handball.Models;
    using Handball.Models.Contracts;
    using Handball.Repositories;
    using Handball.Utilities.Messages;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Controller : IController
    {
        private PlayerRepository players;
        private TeamRepository teams;

        public Controller()
        {
            players = new PlayerRepository();
            teams = new TeamRepository();
        }
        public string NewTeam(string name)
        {
            if (teams.ExistsModel(name))
            {
                return string.Format(OutputMessages.TeamAlreadyExists, name, teams.GetType().Name);
            }
            ITeam team = new Team(name);
            teams.AddModel(team);

            return string.Format(OutputMessages.TeamSuccessfullyAdded, name, teams.GetType().Name);
        }
        public string NewPlayer(string typeName, string name)
        {
            if (typeName != "Goalkeeper" && typeName != "CenterBack" && typeName != "ForwardWing")
            {
                return string.Format(OutputMessages.InvalidTypeOfPosition, typeName);
            }
            if (players.ExistsModel(name))
            {
                return string.Format(OutputMessages.PlayerIsAlreadyAdded, name, players.GetType().Name, players.GetModel(name).GetType().Name);
            }

            IPlayer currPlayer;
            if (typeName == "Goalkeeper")
            {
                currPlayer = new Goalkeeper(name);
            }
            else if (typeName == "CenterBack")
            {
                currPlayer = new CenterBack(name);
            }
            else
            {
                currPlayer = new ForwardWing(name);
            }

            players.AddModel(currPlayer);

            return string.Format(OutputMessages.PlayerAddedSuccessfully, name);

        }


        public string NewContract(string playerName, string teamName)
        {
            if (!players.ExistsModel(playerName))
            {
                return string.Format(OutputMessages.PlayerNotExisting, playerName, nameof(PlayerRepository));
            }
            if (!teams.ExistsModel(teamName))
            {
                return string.Format(OutputMessages.TeamNotExisting, teamName, nameof(TeamRepository));
            }
            if (players.GetModel(playerName).Team != null)
            {
                return string.Format(OutputMessages.PlayerAlreadySignedContract, playerName, players.GetModel(playerName).Team);
            }

            IPlayer player = players.GetModel(playerName);
            ITeam team = teams.GetModel(teamName);
            player.JoinTeam(teamName);
            team.SignContract(player);
            return string.Format(OutputMessages.SignContract, playerName, teamName);

        }


        public string NewGame(string firstTeamName, string secondTeamName)
        {
            ITeam firstTeam = teams.GetModel(firstTeamName);
            ITeam secondTeam = teams.GetModel(secondTeamName);

            if (firstTeam.OverallRating > secondTeam.OverallRating)
            {
                firstTeam.Win();
                secondTeam.Lose();
                return string.Format(OutputMessages.GameHasWinner, firstTeamName, secondTeamName);
            }
            else if (secondTeam.OverallRating > firstTeam.OverallRating)
            {
                secondTeam.Win();
                firstTeam.Lose();
                return string.Format(OutputMessages.GameHasWinner, secondTeamName, firstTeamName);
            }
            else
            {
                firstTeam.Draw();
                secondTeam.Draw();
                return string.Format(OutputMessages.GameIsDraw, firstTeamName, secondTeamName);
            }
        }


        public string PlayerStatistics(string teamName)
        {
            ITeam team = teams.GetModel(teamName);
            List<IPlayer> players = team.Players.OrderByDescending(p => p.Rating).ThenBy(p => p.Name).ToList();


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"***{teamName}***");
            foreach (var player in players)
            {
                sb.AppendLine(player.ToString());
            }

            return sb.ToString().TrimEnd();
        }


        public string LeagueStandings()
        {
            List<ITeam> currTeams = teams.Models.OrderByDescending(t => t.PointsEarned).ThenByDescending(t => t.OverallRating).ThenBy(t => t.Name).ToList();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"***League Standings***");
            foreach (var team in currTeams)
            {
                sb.AppendLine(team.ToString());
            }

            return sb.ToString().TrimEnd();
        }
       
    }
}
