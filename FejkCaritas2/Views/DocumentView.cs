using FejkCaritas2.Views;
using System;

public class DocumentView
{
    public int ID { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int NumberOfHours { get; set; }
    public int VolunteerId { get; set; }
    public DocumentTypeView DocumentType { get; set; }
    public int DocumentTypeID { get; set; }

}
