using System.Data.Entity.ModelConfiguration;

namespace FejkCaritas.Models
{
        public class VolunteeringHoursConfiguration : EntityTypeConfiguration<VolunteeringHours>
        {
            public VolunteeringHoursConfiguration()
            {
                Property(h => h.NumberOfHours)
                    .IsRequired();
                Property(h => h.EndDate)
                    .IsOptional();
                Property(h => h.StartDate)
                    .IsRequired();
                Property(h => h.CreationDate)
                    .IsRequired();
                HasKey(h => h.ID);

                HasRequired(v => v.Volunteer)
                    .WithMany(v => v.VolunteeringHours)
                    .HasForeignKey(v => v.VolunteerID);
            }
        }
}
