using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary
{
    public class Team
    {
        public List<Person> teamMembers { get; set; } = new List<Person>();
        private string teamName;

        public string TeamName
        {
            get { return teamName; }
            set { Tools.CheckStringIsNotEmpty(teamName, value); }
        }
    }
}
