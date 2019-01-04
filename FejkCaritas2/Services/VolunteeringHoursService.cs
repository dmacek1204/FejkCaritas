using FejkCaritas.Models;
using FejkCaritas2.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace FejkCaritas2.Services
{
    public class VolunteeringHoursService : IVolunteeringHoursService
    {
        private VolunteerContext _context;

        public VolunteeringHoursService()
        {
            this._context = new VolunteerContext();
        }

        public VolunteeringHours GetVolunteeringHours(int id)
        {
            var result = _context.VolunteeringHours.SingleOrDefault(c => c.ID == id);
            return result;
        }

        public int GetVolunteeringHoursCountForVolunteer(int volunteerID)
        {
            var result = _context.VolunteeringHours.Where(c => c.VolunteerID == volunteerID).OrderBy(c => c.StartDate);

            return result.Count();
        }

        public IEnumerable<VolunteeringHours> GetVolunteeringHoursForVolunteer(int volunteerID, int pageIndex, int pageSize)
        {
            var result = _context.VolunteeringHours.Where(c => c.VolunteerID == volunteerID).OrderBy(c => c.StartDate);

            return result.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }

        public bool AddVolunteeringHours(VolunteeringHours VolunteeringHour)
        {
            _context.VolunteeringHours.Add(VolunteeringHour);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateVolunteeringHours(VolunteeringHours VolunteeringHours)
        {
            var dbVolunteeringHours = _context.VolunteeringHours.SingleOrDefault(c => c.ID == VolunteeringHours.ID);
            dbVolunteeringHours.NumberOfHours = VolunteeringHours.NumberOfHours;
            dbVolunteeringHours.StartDate = VolunteeringHours.StartDate;
            dbVolunteeringHours.EndDate = VolunteeringHours.EndDate;
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteVolunteeringHours(int id)
        {
            var dbVolunteeringHours = _context.VolunteeringHours.SingleOrDefault(c => c.ID == id);
            _context.VolunteeringHours.Remove(dbVolunteeringHours);
            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}