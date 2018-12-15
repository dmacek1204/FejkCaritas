using System.Data.Entity.ModelConfiguration;

public class CitizenshipConfiguration : EntityTypeConfiguration<Citizenship>
{
    public CitizenshipConfiguration()
    {
        HasKey(c => c.ID);

        Property(c => c.Name)
            .HasMaxLength(250)
            .IsRequired();

        HasMany(c => c.Volunteers)
            .WithOptional(v => v.Citizenship)
            .HasForeignKey(v => v.CitizenshipID);

        HasIndex(c => c.Name).IsUnique();
    }
}