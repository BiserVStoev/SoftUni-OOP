using System;

namespace FootballLeague.Models
{
    public class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(int id, Team homeTeam, Team awayTeam, Score score)
        {
            this.HomeTeam = homeTeam;
            this.AwayTeam = awayTeam;
            this.Score = score;
            this.Id = id;
        }

        public Team HomeTeam
        {
            get { return this.homeTeam; }
            set
            {
                if (String.IsNullOrWhiteSpace(value.Name))
                {
                    throw new ArgumentException("Team name cannot be empty");
                }
                this.homeTeam = value;
            }
        }

        public Team AwayTeam
        {
            get { return this.awayTeam; }
            set
            {
                if (this.homeTeam.Name == value.Name)
                {
                    throw new ArgumentException("Teams cannot have the same name");
                }else if (String.IsNullOrWhiteSpace(value.Name))
                {
                    
                    throw new ArgumentException("Team name cannot be empty");
                }

                this.awayTeam = value;
            }
        }

        public Score Score { get; set; }

        public int Id { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }

            return this.Score.HomeTeamGoals > this.Score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            return String.Format("{0} vs {1}", this.HomeTeam.Name, this.AwayTeam.Name);
        }
    }
}
