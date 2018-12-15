using FejkCaritas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FejkCaritas2.Services
{
    public class CatalogueService
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