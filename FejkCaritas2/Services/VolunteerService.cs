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

        public List<Volunteer> GetVolunteerCollection()
        {
            var query = _context.Volunteers.OrderBy(v => v.ID);

            return query.ToList();
        }
    }
}
