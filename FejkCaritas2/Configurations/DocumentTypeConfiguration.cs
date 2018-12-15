using System.Data.Entity.ModelConfiguration;

public class DocumentTypeConfiguration : EntityTypeConfiguration<DocumentType>
{
    public DocumentTypeConfiguration()
    {
        HasKey(d => d.ID);
        Property(d => d.Name)
            .HasMaxLength(250)
            .IsRequired();

        HasMany(d => d.Documents)
            .WithRequired(d => d.DocumentType)
            .HasForeignKey(d => d.DocumentTypeID);

        HasIndex(d => d.Name).IsUnique();
    }
}