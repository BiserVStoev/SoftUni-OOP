using System;
using System.Linq;
using FootballLeague.Models;

namespace FootballLeague
{
    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam": AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch": AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam": AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams": ListTeams();
                    break;
                case "ListMatches": ListMatches();
                    break;
            }
        }

        private static void AddTeam(string name, string nickname, DateTime dateOfFounding)
        {
            League.AddTeam(new Team(name, nickname, dateOfFounding));
            Console.WriteLine("Team successfully added");
        }

        private static void AddMatch(int id, string homeTeam, string awayTeam, int firstTeamScore, int secondTeamScore)
        {
            Team home = League.Teams.First(team => team.Name == homeTeam);
            Team away = League.Teams.First(team => team.Name == awayTeam);

            League.AddMatch(new Match(id, home, away, new Score(firstTeamScore, secondTeamScore)));
            Console.WriteLine("Match successfully added - {0} vs {1}", homeTeam, awayTeam);
        }

        private static void AddPlayerToTeam(string firstName, string secondName, DateTime dateOfBirth, decimal salary, string teamName)
        {
            Team team = League.Teams.First(t => t.Name == teamName);

            Player player = new Player(firstName, secondName, salary, dateOfBirth, team);

            League.Teams.First(t => t.Name == teamName).AddPlayer(player);
        }

        private static void ListTeams()
        {
            foreach (var team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void ListMatches()
        {
            foreach (var match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }

    }
}
