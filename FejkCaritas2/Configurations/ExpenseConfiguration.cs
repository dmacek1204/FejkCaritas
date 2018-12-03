using System.Data.Entity.ModelConfiguration;

public class ExpenseConfiguration : EntityTypeConfiguration<Expense>
{
    public ExpenseConfiguration()
    {
        HasKey(e => e.ID);
        Property(e => e.Year)
            .IsRequired();
        Property(e => e.Amount)
            .IsRequired();
        Property(e => e.Description)
            .IsOptional();            
    }
}