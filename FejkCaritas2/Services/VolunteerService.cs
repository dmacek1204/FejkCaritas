using FejkCaritas.Models;
using FejkCaritas2.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejkCaritas2.Services
{
    public class VolunteerService : IVolunteerService
    {
        private VolunteerContext _context;

        public VolunteerService()
        {
            this._context = new VolunteerContext();
        }

        public List<Volunteer> GetVolunteerCollection(int pageIndex, int pageSize)
        {
            var query = _context.Volunteers.OrderBy(v => v.ID);

            var paginatedQuery = query.Skip(pageIndex * pageSize).Take(pageSize);

            return paginatedQuery.ToList();
        }

        public Volunteer GetVolunteer(int ID)
        {
            var query = _context.Volunteers.SingleOrDefault(v => v.ID == ID);
            return query;
        }
    }
}
