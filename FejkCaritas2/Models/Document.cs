using FejkCaritas.Models;
using System;

public class Document
{
    public int ID { get; set; }
    public DateTime StartDate{ get; set; }
    public DateTime EndDate { get; set; }
    public int NumberOfHours { get; set; }
    public int VolunteerId { get; set; }
    public Volunteer Volunteer { get; set; }
    public DocumentType DocumentType { get; set; }
    public int DocumentTypeID { get; set; }

}
