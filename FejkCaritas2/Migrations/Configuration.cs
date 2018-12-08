namespace FejkCaritas2.Migrations
{
    using FejkCaritas.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FejkCaritas.Models.VolunteerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FejkCaritas.Models.VolunteerContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Sexes.AddOrUpdate(
                new Sex { ID = 1, Name = "Muško" },
                new Sex { ID = 2, Name = "Žensko" });
            context.ExpenseTypes.AddOrUpdate(
                new ExpenseType { ID = 1, Name = "Troškovi prijevoza" },
                new ExpenseType { ID = 2, Name = "Troškovi smještaja" },
                new ExpenseType { ID = 3, Name = "Troškovi prehrane" },
                new ExpenseType { ID = 4, Name = "Troškovi edukacije" },
                new ExpenseType { ID = 5, Name = "OstaliTroškovi" });
            context.DocumentTypes.AddOrUpdate(
                new DocumentType { ID = 1, Name = "Potvrda o volontiranju" },
                new DocumentType { ID = 2, Name = "Potvrda o stečenim stručnim kompetencijama" });
            context.Citizenships.AddOrUpdate(
                new Citizenship { ID = 1, Name = "Hrvatsko" },
                new Citizenship { ID = 2, Name = "Njemačko" },
                new Citizenship { ID = 3, Name = "Austrijsko" },
                new Citizenship { ID = 4, Name = "Švicarsko" });
            context.Volunteers.AddOrUpdate(
                new Volunteer
                {
                    ID = 1,
                    Birthday = new DateTime(1971, 12, 3),
                    CitizenshipID = 1,
                    Citizenship = new Citizenship { ID = 1, Name = "Hrvatsko" },                    
                    OIB = "11111111111",
                    Email = "email@burek.com",
                    FirstName = "Domba",
                    LastName = "Plomba",
                    Username = "DombaPlomba",
                    SexID = 1,
                    Sex = new Sex { ID = 1, Name = "Muško" },
                    OutsideVolunteer = true,
                    PotentialVolunteer = false,
                },
                new Volunteer
                {
                    ID = 2,
                    Birthday = new DateTime(1987, 4, 21),
                    CitizenshipID = 2,
                    Citizenship = new Citizenship { ID = 2, Name = "Njemačko" },
                    OIB = "11111111123",
                    FirstName = "Gogsan",
                    LastName = "Plogsan",
                    Username = "Gogo",
                    SexID = 1,
                    Sex = new Sex { ID = 1, Name = "Muško" },
                    OutsideVolunteer = true,
                    PotentialVolunteer = false,
                });
        }
    }
}
