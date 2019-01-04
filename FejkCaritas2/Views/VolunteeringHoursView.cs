using System;

namespace FejkCaritas2.Views
{
    public class VolunteeringHoursView
    {
        public int ID;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumberOfHours { get; set; }
        public DateTime CreationDate { get; set; }
        public int VolunteerID { get; set; }
    }
}