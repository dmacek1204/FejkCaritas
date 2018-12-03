using System.Data.Entity.ModelConfiguration;

public class DocumentTypeConfiguration : EntityTypeConfiguration<DocumentType>
{
    public DocumentTypeConfiguration()
    {
        HasKey(d => d.ID);
        Property(d => d.Name)
            .IsRequired();

        HasMany(d => d.Documents)
            .WithRequired(d => d.DocumentType)
            .HasForeignKey(d => d.DocumentTypeID);
    }
}