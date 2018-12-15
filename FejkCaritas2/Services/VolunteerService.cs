using FejkCaritas.Models;
using FejkCaritas2.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FejkCaritas2.Services
{
    public class VolunteerService : IVolunteerService
    {
        private VolunteerContext _context;

        public VolunteerService()
        {
            this._context = new VolunteerContext();
        }

        public int GetVolunteerCount()
        {
            var query = _context.Volunteers.Count();
            return query;
        }

        public List<Volunteer> GetVolunteerCollection(int pageIndex, int pageSize, string sortColumn, string sortOrder)
        {
            var query = SortVolunteerCollection(sortColumn, sortOrder);

            var paginatedQuery = query.Skip(pageIndex * pageSize).Take(pageSize);

            return paginatedQuery.ToList();
        }

        public IOrderedQueryable<Volunteer> SortVolunteerCollection(string sortColumn, string sortOrder)
        {
            if(sortColumn == null || sortOrder == null)
            {
                return _context.Volunteers.OrderBy(v => v.ID);
            }

            switch (sortColumn)
            {
                case "firstName":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.FirstName) : _context.Volunteers.OrderByDescending(v => v.FirstName);
                case "lastName":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.LastName) : _context.Volunteers.OrderByDescending(v => v.LastName);
                case "oib":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.OIB) : _context.Volunteers.OrderByDescending(v => v.OIB);
                case "email":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.Email) : _context.Volunteers.OrderByDescending(v => v.Email);
                case "username":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.Username) : _context.Volunteers.OrderByDescending(v => v.Username);
                case "birthday":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.Birthday) : _context.Volunteers.OrderByDescending(v => v.Birthday);
                case "sex":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.Sex.Name) : _context.Volunteers.OrderByDescending(v => v.Sex.Name);
                case "potentialVolunteer":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.PotentialVolunteer) : _context.Volunteers.OrderByDescending(v => v.PotentialVolunteer);
                case "outsideVolunteer":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.OutsideVolunteer) : _context.Volunteers.OrderByDescending(v => v.OutsideVolunteer);
                case "citizenship":
                    return sortOrder.Equals("asc") ? _context.Volunteers.OrderBy(v => v.Citizenship.Name) : _context.Volunteers.OrderByDescending(v => v.Citizenship.Name);
                default:
                    return _context.Volunteers.OrderBy(v => v.ID);
            }
        }

        public Volunteer GetVolunteer(int ID)
        {
            var query = _context.Volunteers.SingleOrDefault(v => v.ID == ID);
            return query;
        }

        public bool AddVolunteer(Volunteer volunteer)
        {
            try
            {
                _context.Volunteers.Add(volunteer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
