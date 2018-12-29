using FejkCaritas.Models;
using FejkCaritas2.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace FejkCaritas2.Services
{
    public class CatalogueService : ICatalogueService
    {
        private VolunteerContext _context;

        public CatalogueService()
        {
            this._context = new VolunteerContext();
        }

        public IEnumerable<Sex> GetSexes()
        {
            var query = _context.Sexes.OrderBy(s => s.Name);
            return query.ToList();
        }

        public IEnumerable<Citizenship> GetCitizenships()
        {
            var query = _context.Citizenships.OrderBy(c => c.Name);
            return query.ToList();
        }
    }
}