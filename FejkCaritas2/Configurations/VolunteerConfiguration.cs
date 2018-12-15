
using System.Data.Entity.ModelConfiguration;

namespace FejkCaritas.Models
{
    public class VolunteerConfiguration : EntityTypeConfiguration<Volunteer>
    {
        public VolunteerConfiguration()
        {
            HasKey(v => v.ID);
            Property(v => v.FirstName)
                .IsRequired();
            Property(v => v.LastName)
                .IsRequired();
            Property(v => v.OIB)
                .HasMaxLength(11)
                .IsRequired();
            Property(v => v.Birthday)
                .IsRequired();
            Property(v => v.OutsideVolunteer)
                .IsRequired();
            Property(v => v.PotentialVolunteer)
                .IsRequired();
            Property(v => v.Email)
                .IsOptional();
            Property(v => v.Username)
                .IsRequired();

            HasMany(v => v.Contracts)
                .WithRequired(c => c.Volunteer)
                .HasForeignKey(c => c.VolunteerID)
                .WillCascadeOnDelete();
            HasMany(v => v.Documents)
                .WithRequired(d => d.Volunteer)
                .HasForeignKey(d => d.VolunteerId)
                .WillCascadeOnDelete();
            HasMany(v => v.Expenses)
                .WithRequired(e => e.Volunteer)
                .HasForeignKey(e => e.VolunteerID)
                .WillCascadeOnDelete();
            HasMany(v => v.VolunteeringHours)
                .WithRequired(v => v.Volunteer)
                .HasForeignKey(v => v.VolunteerID)
                .WillCascadeOnDelete();

            HasIndex(v => v.OIB).IsUnique();
        }
    }
}
