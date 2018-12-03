using FejkCaritas.Models;

public class Expense
{
    public int ID { get; set; }
    public int Amount { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public int ExpenseTypeID { get; set; }
    public ExpenseType ExpenseType { get; set; }
    public int VolunteerID { get; set; }
    public Volunteer Volunteer { get; set; }

}
