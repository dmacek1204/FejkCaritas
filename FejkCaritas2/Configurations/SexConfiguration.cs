using System.Data.Entity.ModelConfiguration;

namespace FejkCaritas.Models
{
    public class SexConfiguration : EntityTypeConfiguration<Sex>
    {
        public SexConfiguration()
        {
            HasKey(s => s.ID);

            Property(s => s.Name)
                .HasMaxLength(250)
                .IsRequired();

            HasMany(s => s.Volunteers)
                .WithOptional(v => v.Sex)
                .HasForeignKey(v => v.SexID);

            HasIndex(s => s.Name).IsUnique();
        }
    }
}

