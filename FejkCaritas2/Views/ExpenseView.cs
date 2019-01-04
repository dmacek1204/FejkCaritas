using FejkCaritas2.Views;

public class ExpenseView
{
    public int ID { get; set; }
    public double Amount { get; set; }
    public int Year { get; set; }
    public string Description { get; set; }
    public ExpenseTypeView ExpenseType { get; set; }
    public int VolunteerID { get; set; }
}
