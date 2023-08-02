using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary
{
    public static class Tools
    {
        public static void CheckStringIsNotEmpty(string prop, string value)
        {
            if (!value.Equals(""))
            {
                prop = value;
            }
            else
            {
                throw new ArgumentException($"{prop.ToUpper()} cannot be empty");
            }
        }
    }
}
