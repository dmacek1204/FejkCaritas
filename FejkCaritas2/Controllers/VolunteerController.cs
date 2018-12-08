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
        public IEnumerable<BasicVolunteerView> Get()
        {
            var result = _service.GetVolunteerCollection();
            var response = _mapper.MapVolunteerCollectionToBasicVolunteerCollection(result);
            return response;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
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