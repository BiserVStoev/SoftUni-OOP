
using System;
using System.Collections.Generic;

namespace FootballLeague.Models
{
    public static class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(Team team) 
        {
            if (teams.Contains(team))
            {
                throw new ArgumentException("Team is already added");
            }
            teams.Add(team);
            

        }

        public static void AddMatch(Match match)
        {
            if (matches.Contains(match))
            {
                throw new ArgumentException("Match is already added");
            }
            matches.Add(match);
            

        }


    }
}
