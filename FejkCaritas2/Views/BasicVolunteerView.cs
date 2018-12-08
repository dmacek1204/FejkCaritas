using FejkCaritas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public Nullable<int> SexID { get; set; }
        public Sex Sex { get; set; }
        public bool PotentialVolunteer { get; set; }
        public bool OutsideVolunteer { get; set; }
        public Citizenship Citizenship { get; set; }
        public Nullable<int> CitizenshipID { get; set; }
    }
}