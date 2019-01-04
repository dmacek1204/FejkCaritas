using System.Collections.Generic;

namespace FejkCaritas2.ServiceInterfaces
{
    interface IExpensesService
    {
        int GetExpenseCountForVolunteer(int volunteerID);
        Expense GetExpense(int id);
        IEnumerable<Expense> GetExpensesForVolunteer(int volunteerID, int pageIndex, int pageSize);
        bool AddExpense(Expense expense);
        bool UpdateExpense(Expense expense);
        bool DeleteExpense(int id);
    }
}
