using System.Collections.Generic;

namespace TournamentTrackerLibrary
{
    public class MatchUp
    {
        public List<MatchUpEntry> entries { get; set; } = new List<MatchUpEntry>();
        public Team winner { get; set; }
        public int matchUpRound { get; set; }

    }   
}