using FejkCaritas.Models;
using System;

public class Contract
{
    public int ID { get; set; }
    public DateTime StartDate { get; set; }
    public Nullable<DateTime> EndDate { get; set; }
    public int NumberOfHours { get; set; }
    public DateTime CreationDate { get; set; }
    public int VolunteerID { get; set; }
    public Volunteer Volunteer { get; set; }
}
