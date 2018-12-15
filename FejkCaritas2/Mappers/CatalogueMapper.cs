using FejkCaritas.Models;
using FejkCaritas2.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FejkCaritas2.Mappers
{
    public class CatalogueMapper
    {
        public SexView MapSexModelToSexView(Sex sex)
        {
            var result = new SexView()
            {
                ID = sex.ID,
                Name = sex.Name
            };
            return result;
        }

        public IEnumerable<SexView> MapSexModelCollectionToSexViewCollection(IEnumerable<Sex> sexes)
        {
            var result = new List<SexView>();
            foreach(Sex sex in sexes)
            {
                result.Add(MapSexModelToSexView(sex));
            }
            return result;
        }

        public CitizenshipView MapCitizenshipToView(Citizenship citizenship)
        {
            var result = new CitizenshipView()
            {
                ID = citizenship.ID,
                Name = citizenship.Name
            };
            return result;
        }

        public IEnumerable<CitizenshipView> MapCitizenshipModelCollectionToCitizenshipViewCollection(IEnumerable<Citizenship> citizenshipColl)
        {
            var result = new List<CitizenshipView>();
            foreach(Citizenship citizenship in citizenshipColl)
            {
                result.Add(MapCitizenshipToView(citizenship));
            }
            return result;
        }
    }
}