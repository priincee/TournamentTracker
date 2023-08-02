using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentTrackerLibrary
{
    public class Person
    {
        private string firstName;
        private string lastName;
        public string emailAddress;
        public string phoneNumber;

        public string FirstName
        {
            get { return firstName; }
            set { Tools.CheckStringIsNotEmpty(firstName, value); }
        }

        public string LastName
        {
            get { return lastName; }
            set { Tools.CheckStringIsNotEmpty(lastName, value); }
        }
    }
}
