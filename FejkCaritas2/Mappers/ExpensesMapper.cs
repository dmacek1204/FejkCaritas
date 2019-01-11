using FejkCaritas2.Views;
using System.Collections.Generic;

namespace FejkCaritas2.Mappers
{
    public class ExpensesMapper
    {
        public ExpenseView MapExpenseToExpenseView(Expense expense)
        {
            var result = new ExpenseView()
            {
                ID = expense.ID,
                Year = expense.Year,
                Amount = expense.Amount,
                ExpenseType = new ExpenseTypeView()
                {
                    ID = expense.ExpenseType.ID,
                    Name = expense.ExpenseType.Name
                },
                Description = expense.Description,
                VolunteerID = expense.VolunteerID
            };
            return result;
        }

        public IEnumerable<ExpenseView> MapExpenseCollectionToExpenseViewCollection(IEnumerable<Expense> expenseColl)
        {
            var result = new List<ExpenseView>();
            foreach (var expense in expenseColl)
            {
                result.Add(MapExpenseToExpenseView(expense));
            }
            return result;
        }

        public Expense MapExpenseViewToExpense(ExpenseView expense)
        {
            var result = new Expense()
            {
                ID = expense.ID,
                Year = expense.Year,
                Amount = expense.Amount,
                ExpenseTypeID = expense.ExpenseType.ID,
                Description = expense.Description,
                VolunteerID = expense.VolunteerID
            };
            return result;
        }
    }
}