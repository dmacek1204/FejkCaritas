using FejkCaritas2.Mappers;
using FejkCaritas2.ServiceInterfaces;
using FejkCaritas2.Services;
using FejkCaritas2.Views;
using System.Web.Http;

namespace FejkCaritas2.Controllers
{
    public class VolunteeringHoursController : ApiController
    {
        private IVolunteeringHoursService _service;
        private VolunteeringHoursMapper _mapper;

        public VolunteeringHoursController()
        {
            this._service = new VolunteeringHoursService();
            this._mapper = new VolunteeringHoursMapper();
        }
        // GET: api/VolunteeringHours/Volunteer
        [HttpGet]
        [Route("api/VolunteeringHours/Volunteer/{id}")]
        public IHttpActionResult GetVolunteeringHoursForVolunteer(int id, int pageIndex, int pageSize)
        {
            var result = _service.GetVolunteeringHoursForVolunteer(id, pageIndex, pageSize);
            var response = _mapper.MapVolunteeringHoursCollectionToVolunteeringHoursViewCollection(result);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/VolunteeringHours/Volunteer/{id}/Count")]
        public IHttpActionResult GetVolunteeringHoursCountForVolunteer(int id)
        {
            var result = _service.GetVolunteeringHoursCountForVolunteer(id);
            return Ok(result);
        }

        // GET: api/VolunteeringHours/5
        public IHttpActionResult Get(int id)
        {
            var result = _service.GetVolunteeringHours(id);
            var response = _mapper.MapVolunteeringHoursToVolunteeringHoursView(result);
            return Ok(response);
        }

        // POST: api/VolunteeringHours
        public IHttpActionResult Post([FromBody] VolunteeringHoursView volunteeringHours)
        {
            var model = _mapper.MapVolunteeringHoursViewToVolunteeringHours(volunteeringHours);
            var result = _service.AddVolunteeringHours(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT: api/VolunteeringHours/5
        public IHttpActionResult Put([FromBody] VolunteeringHoursView volunteeringHours)
        {
            var model = _mapper.MapVolunteeringHoursViewToVolunteeringHours(volunteeringHours);
            var result = _service.UpdateVolunteeringHours(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE: api/VolunteeringHours/5
        public IHttpActionResult Delete(int id)
        {
            var result = _service.DeleteVolunteeringHours(id);
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
