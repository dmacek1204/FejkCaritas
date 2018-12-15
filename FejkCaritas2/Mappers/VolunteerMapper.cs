using FejkCaritas.Models;
using FejkCaritas2.Views;
using System.Collections.Generic;

namespace FejkCaritas2.Mappers
{
    public class VolunteerMapper
    {
        public BasicVolunteerView MapVolunteerToBasicVolunteer(Volunteer volunteer)
        {
            var result = new BasicVolunteerView
            {
                ID = volunteer.ID,
                FirstName = volunteer.FirstName,
                LastName = volunteer.LastName,
                OIB = volunteer.OIB,
                Birthday = volunteer.Birthday,
                Citizenship = new CitizenshipView()
                {
                    ID = volunteer.Citizenship.ID,
                    Name = volunteer.Citizenship.Name
                },
                Username = volunteer.Username,
                Sex = new SexView()
                {
                    ID = volunteer.Sex.ID,
                    Name = volunteer.Sex.Name
                },
                Email = volunteer.Email,
                PotentialVolunteer = volunteer.PotentialVolunteer,
                OutsideVolunteer = volunteer.OutsideVolunteer
            };
            return result;
        }

        public IEnumerable<BasicVolunteerView> MapVolunteerCollectionToBasicVolunteerCollection(IEnumerable<Volunteer> volunteerCollection)
        {
            var result = new List<BasicVolunteerView>();
            foreach (Volunteer volunteer in volunteerCollection)
            {
                var basicVolunteer = this.MapVolunteerToBasicVolunteer(volunteer);
                result.Add(basicVolunteer);
            }

            return result;
        }

        public Volunteer MapVolunteerViewToVolunteer(BasicVolunteerView view)
        {
            var result = new Volunteer()
            {
                ID = 0,
                FirstName = view.FirstName,
                LastName = view.LastName,
                OIB = view.OIB,
                Birthday = view.Birthday,
                PotentialVolunteer = view.PotentialVolunteer,
                OutsideVolunteer = view.OutsideVolunteer,
                CitizenshipID = view.Citizenship.ID,
                SexID = view.Sex.ID,
                Email = view.Email,
                Username = view.Username
            };
            return result;
        }
    }
}