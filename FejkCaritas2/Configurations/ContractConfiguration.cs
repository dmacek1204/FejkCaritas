using System.Data.Entity.ModelConfiguration;

public class ContractConfiguration : EntityTypeConfiguration<Contract>
{
    public ContractConfiguration()
    {
        HasKey(c => c.ID);

        Property(c => c.NumberOfHours)
            .IsRequired();

        Property(c => c.StartDate)
            .IsRequired();

        Property(c => c.EndDate)
            .IsOptional();

        Property(c => c.CreationDate)
            .IsRequired();

        HasRequired(c => c.Volunteer)
            .WithMany(v => v.Contracts)
            .HasForeignKey(c => c.VolunteerID);
    }
}
