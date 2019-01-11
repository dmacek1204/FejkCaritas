using FejkCaritas.Models;

public class Expense
{
    public int ID { get; set; }
    public double Amount { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public int ExpenseTypeID { get; set; }
    public virtual ExpenseType ExpenseType { get; set; }
    public int VolunteerID { get; set; }
    public Volunteer Volunteer { get; set; }

}
