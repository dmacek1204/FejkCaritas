using System;

namespace FejkCaritas2.Views
{
    public class BasicVolunteerView
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string OIB { get; set; }
        public DateTime Birthday { get; set; }
        public SexView Sex { get; set; }
        public bool PotentialVolunteer { get; set; }
        public bool OutsideVolunteer { get; set; }
        public CitizenshipView Citizenship { get; set; }
    }
}