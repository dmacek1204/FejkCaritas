using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FejkCaritas2.Views
{
    public class ContractView
    {
        public int ID { get; set; }
        public DateTime StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public int NumberOfHours { get; set; }
        public DateTime CreationDate { get; set; }
        public int VolunteerID { get; set; }
    }
}