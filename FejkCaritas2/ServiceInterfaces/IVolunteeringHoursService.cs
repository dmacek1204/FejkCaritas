using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejkCaritas2.ServiceInterfaces
{
    interface IVolunteeringHoursService
    {
        int GetVolunteeringHoursCountForVolunteer(int volunteerID);
        VolunteeringHours GetVolunteeringHours(int id);
        IEnumerable<VolunteeringHours> GetVolunteeringHoursForVolunteer(int volunteerID, int pageIndex, int pageSize);
        bool AddVolunteeringHours(VolunteeringHours volunteeringHours);
        bool UpdateVolunteeringHours(VolunteeringHours volunteeringHours);
        bool DeleteVolunteeringHours(int id);
    }
}
