using FejkCaritas2.Mappers;
using FejkCaritas2.ServiceInterfaces;
using FejkCaritas2.Services;
using System.Web.Http;

namespace FejkCaritas2.Controllers
{
    public class ExpensesController : ApiController
    {
        private IExpensesService _service;
        private ExpensesMapper _mapper;

        public ExpensesController()
        {
            this._service = new ExpensesService();
            this._mapper = new ExpensesMapper();
        }
        // GET: api/Expenses/Volunteer
        [HttpGet]
        [Route("api/Expenses/Volunteer/{id}")]
        public IHttpActionResult GetExpenseForVolunteer(int id, int pageIndex, int pageSize)
        {
            var result = _service.GetExpensesForVolunteer(id, pageIndex, pageSize);
            var response = _mapper.MapExpenseCollectionToExpenseViewCollection(result);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/Expenses/Volunteer/{id}/Count")]
        public IHttpActionResult GetExpenseCountForVolunteer(int id)
        {
            var result = _service.GetExpenseCountForVolunteer(id);
            return Ok(result);
        }

        // GET: api/Expenses/5
        public IHttpActionResult Get(int id)
        {
            var result = _service.GetExpense(id);
            var response = _mapper.MapExpenseToExpenseView(result);
            return Ok(response);
        }

        // POST: api/Expenses
        public IHttpActionResult Post([FromBody] ExpenseView expense)
        {
            var model = _mapper.MapExpenseViewToExpense(expense);
            var result = _service.AddExpense(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT: api/Expenses/5
        public IHttpActionResult Put([FromBody] ExpenseView expense)
        {
            var model = _mapper.MapExpenseViewToExpense(expense);
            var result = _service.UpdateExpense(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Expense/5
        public IHttpActionResult Delete(int id)
        {
            var result = _service.DeleteExpense(id);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }
    }
}
