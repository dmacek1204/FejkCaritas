using FejkCaritas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejkCaritas2.ServiceInterfaces
{
    public interface IVolunteerService
    {
        List<Volunteer> GetVolunteerCollection(int pageIndex, int pageSize);
        Volunteer GetVolunteer(int ID);
    }
}
