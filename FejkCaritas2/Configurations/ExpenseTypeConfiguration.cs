using System.Data.Entity.ModelConfiguration;

public class ExpenseTypeConfiguration : EntityTypeConfiguration<ExpenseType>
{
    public ExpenseTypeConfiguration()
    {
        HasKey(e => e.ID);
        Property(e => e.Name)
            .IsRequired();

        HasMany(e => e.Expenses)
            .WithRequired(e => e.ExpenseType)
            .HasForeignKey(e => e.ExpenseTypeID);
    }
}