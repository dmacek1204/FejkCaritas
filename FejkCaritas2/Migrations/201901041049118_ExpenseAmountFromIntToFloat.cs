namespace FejkCaritas2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpenseAmountFromIntToFloat : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Expenses", "Amount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expenses", "Amount", c => c.Int(nullable: false));
        }
    }
}
