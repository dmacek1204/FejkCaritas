using System.Data.Entity.ModelConfiguration;

namespace FejkCaritas.Models
{
    public class SexConfiguration : EntityTypeConfiguration<Sex>
    {
        public SexConfiguration()
        {
            HasKey(s => s.ID);
            Property(s => s.Name)
                .IsRequired();

            HasMany(s => s.Volunteers)
                .WithOptional(v => v.Sex)
                .HasForeignKey(v => v.SexID);
        }
    }
}

