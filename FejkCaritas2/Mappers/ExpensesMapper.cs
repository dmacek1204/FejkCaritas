using FejkCaritas2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FejkCaritas2.Mappers
{
    public class ExpensesMapper
    {
        public ExpenseView MapExpenseToExpenseView(Expense contract)
        {
            var result = new ExpenseView()
            {
                ID = contract.ID,
                Year = contract.Year,
                Amount = contract.Amount,
                ExpenseType = new ExpenseTypeView()
                {
                    ID = contract.ExpenseType.ID,
                    Name = contract.ExpenseType.Name
                },
                Description = contract.Description,
                VolunteerID = contract.VolunteerID
            };
            return result;
        }

        public IEnumerable<ExpenseView> MapExpenseCollectionToExpenseViewCollection(IEnumerable<Expense> contractColl)
        {
            var result = new List<ExpenseView>();
            foreach (var contract in contractColl)
            {
                result.Add(MapExpenseToExpenseView(contract));
            }
            return result;
        }

        public Expense MapExpenseViewToExpense(ExpenseView contract)
        {
            var result = new Expense()
            {
                ID = contract.ID,
                Year = contract.Year,
                Amount = contract.Amount,
                ExpenseTypeID = contract.ExpenseType.ID,
                Description = contract.Description,
                VolunteerID = contract.VolunteerID
            };
            return result;
        }
    }
}