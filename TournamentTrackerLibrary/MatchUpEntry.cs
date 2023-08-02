namespace TournamentTrackerLibrary
{
    public class MatchUpEntry
    {
        public Team teamCompeting { get; set; }
        public double score { get; set; }
        public MatchUp parentMatchUp { get; set; }
    }
}