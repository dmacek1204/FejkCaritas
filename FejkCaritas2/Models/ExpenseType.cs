using System.Collections.Generic;
using System.Collections.ObjectModel;

public class ExpenseType
{
    public int ID { get; set; }
    public string Name { get; set; }

    public ICollection<Expense> Expenses { get; set; }
}
