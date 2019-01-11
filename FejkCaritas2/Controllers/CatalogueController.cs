using FejkCaritas2.Mappers;
using FejkCaritas2.ServiceInterfaces;
using FejkCaritas2.Services;
using FejkCaritas2.Views;
using System.Collections.Generic;
using System.Web.Http;

namespace FejkCaritas2.Controllers
{
    public class CatalogueController : ApiController
    {
        private ICatalogueService _service;
        private CatalogueMapper _mapper;

        public CatalogueController()
        {
            this._service = new CatalogueService();
            this._mapper = new CatalogueMapper();
        }

        // GET: api/Catalogue
        [HttpGet]
        [Route("api/Catalogue/Sex")]
        public IEnumerable<SexView> GetSexes()
        {
            var result = _service.GetSexes();
            var response = _mapper.MapSexModelCollectionToSexViewCollection(result);
            return response;
        }

        [HttpGet]
        [Route("api/Catalogue/Citizenship")]
        public IEnumerable<CitizenshipView> GetCitizenships()
        {
            var result = _service.GetCitizenships();
            var response = _mapper.MapCitizenshipModelCollectionToCitizenshipViewCollection(result);
            return response;
        }

        [HttpGet]
        [Route("api/Catalogue/DocumentType")]
        public IEnumerable<DocumentTypeView> GetDocumentTypes()
        {
            var result = _service.GetDocumentTypes();
            var response = _mapper.MapDocumentTypeModelCollectionToDocumentTypeViewCollection(result);
            return response;
        }

        [HttpGet]
        [Route("api/Catalogue/ExpenseType")]
        public IEnumerable<ExpenseTypeView> GetExpenseTypes()
        {
            var result = _service.GetExpenseTypes();
            var response = _mapper.MapExpenseTypeModelCollectionToExpenseTypeViewCollection(result);
            return response;
        }
    }
}
