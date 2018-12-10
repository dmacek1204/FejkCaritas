using FejkCaritas.Models;
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
        private VolunteerMapper _mapper;

        public VolunteerController()
        {
            this._service = new VolunteerService();
            this._mapper = new VolunteerMapper();
        }

        // GET api/<controller>
        [HttpGet]
        public IHttpActionResult Get(string pageIndex, string pageSize)
        {
            var result = _service.GetVolunteerCollection(Int32.Parse(pageIndex), Int32.Parse(pageSize));
            var response = _mapper.MapVolunteerCollectionToBasicVolunteerCollection(result);
            return Ok(response);
        }

        // GET api/<controller>/5
        public IHttpActionResult GetVolunteer(int id)
        {
            var result =  _service.GetVolunteer(id);
            if(result == null)
            {
                return BadRequest("Not found.");
            }
            var response = _mapper.MapVolunteerToBasicVolunteer(result);
            return Ok(response);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}