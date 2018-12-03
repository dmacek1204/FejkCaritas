using System.Data.Entity.ModelConfiguration;

public class DocumentConfiguration : EntityTypeConfiguration<Document>
{
    public DocumentConfiguration()
    {
        HasKey(d => d.ID);
        Property(d => d.NumberOfHours)
            .IsRequired();
        Property(d => d.StartDate)
            .IsRequired();
        Property(d => d.EndDate)
            .IsOptional();
        

    }
}