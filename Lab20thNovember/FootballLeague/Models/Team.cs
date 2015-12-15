
using System;
using System.Collections.Generic;
using System.Linq;
using FootballLeague.Models;

namespace FootballLeague
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateOfFounding;
        private List<Player> players;


        public Team(string name, string nickname, DateTime dateOfFounding)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFounding;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Team name should be atleast 5 characters long");
                } 
                this.name = value;
            }
        }

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Team nickname should be atleast 5 characters long");
                }
                this.nickname = value;
            }
        }

        public DateTime DateOfFounding
        {
            get { return this.dateOfFounding; }
            set
            {
                this.dateOfFounding = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team");
            }

            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
