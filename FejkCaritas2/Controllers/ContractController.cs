using FejkCaritas2.Mappers;
using FejkCaritas2.ServiceInterfaces;
using FejkCaritas2.Services;
using FejkCaritas2.Views;
using System.Web.Http;

namespace FejkCaritas2.Controllers
{
    public class ContractController : ApiController
    {
        private IContractService _service;
        private ContractMapper _mapper;

        public ContractController()
        {
            this._service = new ContractService();
            this._mapper = new ContractMapper();
        }
        // GET: api/Contract/Volunteer
        [HttpGet]
        [Route("api/Contract/Volunteer/{id}")]
        public IHttpActionResult GetContractForVolunteer(int id, int pageIndex, int pageSize)
        {
            var result = _service.GetContractsForVolunteer(id, pageIndex, pageSize);
            var response = _mapper.MapContractCollectionToContractViewCollection(result);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/Contract/Volunteer/{id}/Count")]
        public IHttpActionResult GetContractCountForVolunteer(int id)
        {
            var result = _service.GetContractCountForVolunteer(id);
            return Ok(result);
        }

        // GET: api/Contract/5
        public IHttpActionResult Get(int id)
        {
            var result = _service.GetContract(id);
            var response = _mapper.MapContractToContractView(result);
            return Ok(response);
        }

        // POST: api/Contract
        public IHttpActionResult Post([FromBody] ContractView contract)
        {
            var model = _mapper.MapContractViewToContract(contract);
            var result = _service.AddContract(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT: api/Contract/5
        public IHttpActionResult Put([FromBody] ContractView contract)
        {
            var model = _mapper.MapContractViewToContract(contract);
            var result = _service.UpdateContract(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Contract/5
        public IHttpActionResult Delete(int id)
        {
            var result = _service.DeleteContract(id);
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
