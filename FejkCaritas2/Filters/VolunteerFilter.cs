using System;

namespace FejkCaritas2.Filters
{
    public class VolunteerFilter
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string OIB { get; set; }
        public Nullable<DateTime> Birthday { get; set; }
        public Nullable<int> SexID { get; set; }
        public Nullable<bool> PotentialVolunteer { get; set; }
        public Nullable<bool> OutsideVolunteer { get; set; }
        public Nullable<int> CitizenshipID { get; set; }
    }
}