using FejkCaritas.Models;
using FejkCaritas2.Filters;
using FejkCaritas2.Mappers;
using FejkCaritas2.ServiceInterfaces;
using FejkCaritas2.Services;
using FejkCaritas2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace FejkCaritas2.Controllers
{
    public class VolunteerController : ApiController
    {
        private IVolunteerService _service;
        private VolunteerMapper _volunteerMapper;

        public VolunteerController()
        {
            this._service = new VolunteerService();
            this._volunteerMapper = new VolunteerMapper();
        }

        [HttpGet]
        [Route("api/Volunteer/Search")]
        public IHttpActionResult Search([FromUri] VolunteerFilter filter, int pageSize, int pageIndex, string sortOrder, string sortColumn)
        {
            var totalCount = 0;
            var result = _service.Search(filter, pageIndex, pageSize, sortColumn, sortOrder, out totalCount);
            var data = _volunteerMapper.MapVolunteerCollectionToBasicVolunteerCollection(result);
            var response = new FilterResponse()
            {
                data = data,
                totalCount = totalCount
            };
            return Ok(response);
        }

        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult Get(string pageIndex, string pageSize, string sortColumn, string sortOrder)
        {
            var result = _service.GetVolunteerCollection(Int32.Parse(pageIndex), Int32.Parse(pageSize), sortColumn, sortOrder);
            var response = _volunteerMapper.MapVolunteerCollectionToBasicVolunteerCollection(result);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/Volunteer/Count")]
        public IHttpActionResult GetVolunteerCount()
        {
            var result = _service.GetVolunteerCount();
            return Ok(result);
        }

        // GET api/<controller>/5
        public IHttpActionResult GetVolunteer(int id)
        {
            var result =  _service.GetVolunteer(id);
            if(result == null)
            {
                return BadRequest("Not found.");
            }
            var response = _volunteerMapper.MapVolunteerToBasicVolunteer(result);
            return Ok(response);
        }

        // POST api/<controller>
        public IHttpActionResult PostVolunteer([FromBody] BasicVolunteerView volunteer)
        {
            var model = _volunteerMapper.MapVolunteerViewToVolunteer(volunteer);
            var result = _service.AddVolunteer(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put([FromBody] BasicVolunteerView volunteer)
        {
            var model = _volunteerMapper.MapVolunteerViewToVolunteer(volunteer);
            var result = _service.UpdateVolunteer(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
           var result = _service.DeleteVolunteer(id);
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