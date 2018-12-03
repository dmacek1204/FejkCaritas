using System.Data.Entity.ModelConfiguration;

public class CitizenshipConfiguration : EntityTypeConfiguration<Citizenship>
{
    public CitizenshipConfiguration()
    {
        HasKey(c => c.ID);

        Property(c => c.Name)
            .IsRequired();

        HasMany(c => c.Volunteers)
            .WithOptional(v => v.Citizenship)
            .HasForeignKey(v => v.CitizenshipID);
    }
}