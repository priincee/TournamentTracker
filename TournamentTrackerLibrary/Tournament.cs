using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary
{
    public class Tournament
    {
        private string tournamentName { get; set; }
        public decimal entryFee { get; set; }
        public List<Team> enteredTeams { get; set; } = new List<Team>();
        public List<Prize> prizes { get; set; } = new List<Prize>();

        public List<MatchUp> rounds { get; set; } = new List<MatchUp>();

        public string TournamentName
        {
            get { return tournamentName; }
            set { Tools.CheckStringIsNotEmpty(tournamentName, value); }
        }
    }
}
