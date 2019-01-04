using FejkCaritas2.Views;
using System.Collections.Generic;

namespace FejkCaritas2.Mappers
{
    public class VolunteeringHoursMapper
    {
        public VolunteeringHoursView MapVolunteeringHoursToVolunteeringHoursView(VolunteeringHours volunteeringHours)
        {
            var result = new VolunteeringHoursView()
            {
                ID = volunteeringHours.ID,
                StartDate = volunteeringHours.StartDate,
                EndDate = volunteeringHours.EndDate,
                NumberOfHours = volunteeringHours.NumberOfHours,
                CreationDate = volunteeringHours.CreationDate,
                VolunteerID = volunteeringHours.VolunteerID
            };
            return result;
        }

        public IEnumerable<VolunteeringHoursView> MapVolunteeringHoursCollectionToVolunteeringHoursViewCollection(IEnumerable<VolunteeringHours> volunteeringHoursColl)
        {
            var result = new List<VolunteeringHoursView>();
            foreach (var volunteeringHours in volunteeringHoursColl)
            {
                result.Add(MapVolunteeringHoursToVolunteeringHoursView(volunteeringHours));
            }
            return result;
        }

        public VolunteeringHours MapVolunteeringHoursViewToVolunteeringHours(VolunteeringHoursView volunteeringHours)
        {
            var result = new VolunteeringHours()
            {
                ID = volunteeringHours.ID,
                StartDate = volunteeringHours.StartDate,
                EndDate = volunteeringHours.EndDate,
                NumberOfHours = volunteeringHours.NumberOfHours,
                CreationDate = volunteeringHours.CreationDate,
                VolunteerID = volunteeringHours.VolunteerID
            };
            return result;
        }
    }
}