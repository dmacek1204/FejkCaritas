using FejkCaritas.Models;
using FejkCaritas2.Filters;
using System.Collections.Generic;

namespace FejkCaritas2.ServiceInterfaces
{
    public interface IVolunteerService
    {
        List<Volunteer> GetVolunteerCollection(int pageIndex, int pageSize, string sortColumn, string sortOrder);
        Volunteer GetVolunteer(int ID);
        int GetVolunteerCount();
        bool AddVolunteer(Volunteer volunteer);
        IEnumerable<Volunteer> Search(VolunteerFilter filter, int pageIndex, int pageSize, string sortColumn, string sortOrder, out int totalCount);
        bool DeleteVolunteer(int ID);
        bool UpdateVolunteer(Volunteer volunteer);
    }
}
