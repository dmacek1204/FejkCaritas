using FejkCaritas.Models;
using FejkCaritas2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
                Citizenship = volunteer.Citizenship,
                Username = volunteer.Username,
                Sex = volunteer.Sex,
                Email = volunteer.Email,
                PotentialVolunteer = volunteer.PotentialVolunteer,
                OutsideVolunteer = volunteer.OutsideVolunteer
            };
            return result;
        } 
        
        public IEnumerable<BasicVolunteerView> MapVolunteerCollectionToBasicVolunteerCollection(IEnumerable<Volunteer> volunteerCollection)
        {
            var result = new List<BasicVolunteerView>();
            foreach(Volunteer volunteer in volunteerCollection)
            {
                var basicVolunteer = this.MapVolunteerToBasicVolunteer(volunteer);
                result.Add(basicVolunteer);
            }

            return result;
        }
    }
}