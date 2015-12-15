using System;

namespace FootballLeague.Models
{
    public class Score
    {
        private int awayTeamGoals;
        private int homeTeamGoals;

        public Score(int awayTeamGoals, int homeTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoals;
        }

        public int AwayTeamGoals
        {
            get { return this.awayTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");
                }
                this.awayTeamGoals = value;
            }
        }

        public int HomeTeamGoals
        {
            get { return this.homeTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Goals cannot be negative");
                }
                this.homeTeamGoals = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", this.HomeTeamGoals, this.AwayTeamGoals);
        }
    }
}
