using System;
using System.Collections.Generic;

namespace FejkCaritas.Models
{
    public class Volunteer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string OIB { get; set; }
        public DateTime Birthday { get; set; }
        public Nullable<int> SexID { get; set; }
        public virtual Sex Sex { get; set; }
        public bool PotentialVolunteer { get; set; }
        public bool OutsideVolunteer { get; set; }
        public ICollection<VolunteeringHours> VolunteeringHours { get; set; }
        public ICollection<Document> Documents { get; set; }
        public ICollection<Expense> Expenses { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public virtual Citizenship Citizenship { get; set; }
        public Nullable<int> CitizenshipID { get; set; }

    }
}
