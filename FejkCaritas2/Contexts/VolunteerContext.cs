using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FejkCaritas.Models
{
    public partial class VolunteerContext : DbContext
    {
        public VolunteerContext()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer<VolunteerContext>(new DropCreateDatabaseIfModelChanges<VolunteerContext>());
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new VolunteeringHoursConfiguration());
            modelBuilder.Configurations.Add(new CitizenshipConfiguration());
            modelBuilder.Configurations.Add(new ExpenseConfiguration());
            modelBuilder.Configurations.Add(new ContractConfiguration());
            modelBuilder.Configurations.Add(new DocumentConfiguration());
            modelBuilder.Configurations.Add(new DocumentTypeConfiguration());
            modelBuilder.Configurations.Add(new ExpenseTypeConfiguration());
            modelBuilder.Configurations.Add(new SexConfiguration());
            modelBuilder.Configurations.Add(new VolunteerConfiguration());

        }

        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseType> ExpenseTypes { get; set; }
        public DbSet<VolunteeringHours> Hours { get; set; }
        public DbSet<Sex> Sexes { get; set; }
        public DbSet<Citizenship> Citizenships { get; set; }
    }

}
