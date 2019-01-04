using FejkCaritas.Models;
using FejkCaritas2.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace FejkCaritas2.Services
{
    public class ExpensesService : IExpensesService
    {
        private VolunteerContext _context;

        public ExpensesService()
        {
            this._context = new VolunteerContext();
        }

        public Expense GetExpense(int id)
        {
            var result = _context.Expenses.SingleOrDefault(c => c.ID == id);
            return result;
        }

        public int GetExpenseCountForVolunteer(int volunteerID)
        {
            var result = _context.Expenses.Where(e => e.VolunteerID == volunteerID).OrderBy(e => e.Year);

            return result.Count();
        }

        public IEnumerable<Expense> GetExpensesForVolunteer(int volunteerID, int pageIndex, int pageSize)
        {
            var result = _context.Expenses.Where(c => c.VolunteerID == volunteerID).OrderBy(c => c.Year);

            return result.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }

        public bool AddExpense(Expense expense)
        {
            _context.Expenses.Add(expense);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateExpense(Expense expense)
        {
            var dbExpense = _context.Expenses.SingleOrDefault(c => c.ID == expense.ID);
            dbExpense.Year = expense.Year;
            dbExpense.Amount = expense.Amount;
            dbExpense.ExpenseTypeID = expense.ExpenseTypeID;
            dbExpense.Description = expense.Description;
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteExpense(int id)
        {
            var dbExpense = _context.Expenses.SingleOrDefault(c => c.ID == id);
            _context.Expenses.Remove(dbExpense);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}