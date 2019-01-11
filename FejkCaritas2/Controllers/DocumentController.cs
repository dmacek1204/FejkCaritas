using FejkCaritas2.Mappers;
using FejkCaritas2.ServiceInterfaces;
using FejkCaritas2.Services;
using System.Web.Http;

namespace FejkCaritas2.Controllers
{
    public class DocumentController : ApiController
    {
        private IDocumentService _service;
        private DocumentMapper _mapper;

        public DocumentController()
        {
            this._service = new DocumentService();
            this._mapper = new DocumentMapper();
        }
        // GET: api/Document/Volunteer
        [HttpGet]
        [Route("api/Document/Volunteer/{id}")]
        public IHttpActionResult GetDocumentForVolunteer(int id, int pageIndex, int pageSize)
        {
            var result = _service.GetDocumentsForVolunteer(id, pageIndex, pageSize);
            var response = _mapper.MapDocumentCollectionToDocumentViewCollection(result);
            return Ok(response);
        }

        [HttpGet]
        [Route("api/Document/Volunteer/{id}/Count")]
        public IHttpActionResult GetDocumentCountForVolunteer(int id)
        {
            var result = _service.GetDocumentCountForVolunteer(id);
            return Ok(result);
        }

        // GET: api/Document/5
        public IHttpActionResult Get(int id)
        {
            var result = _service.GetDocument(id);
            var response = _mapper.MapDocumentToDocumentView(result);
            return Ok(response);
        }

        // POST: api/Document
        public IHttpActionResult Post([FromBody] DocumentView document)
        {
            var model = _mapper.MapDocumentViewToDocument(document);
            var result = _service.AddDocument(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // PUT: api/Document/5
        public IHttpActionResult Put([FromBody] DocumentView document)
        {
            var model = _mapper.MapDocumentViewToDocument(document);
            var result = _service.UpdateDocument(model);
            if (result)
            {
                return Ok(result);
            }
            else
            {
                return InternalServerError();
            }
        }

        // DELETE: api/Document/5
        public IHttpActionResult Delete(int id)
        {
            var result = _service.DeleteDocument(id);
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
