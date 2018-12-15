namespace FejkCaritas2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UniqueConstraintsAdd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Citizenships", "Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.DocumentTypes", "Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.ExpenseTypes", "Name", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.Sexes", "Name", c => c.String(nullable: false, maxLength: 250));
            CreateIndex("dbo.Citizenships", "Name", unique: true);
            CreateIndex("dbo.Volunteers", "OIB", unique: true);
            CreateIndex("dbo.DocumentTypes", "Name", unique: true);
            CreateIndex("dbo.ExpenseTypes", "Name", unique: true);
            CreateIndex("dbo.Sexes", "Name", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Sexes", new[] { "Name" });
            DropIndex("dbo.ExpenseTypes", new[] { "Name" });
            DropIndex("dbo.DocumentTypes", new[] { "Name" });
            DropIndex("dbo.Volunteers", new[] { "OIB" });
            DropIndex("dbo.Citizenships", new[] { "Name" });
            AlterColumn("dbo.Sexes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ExpenseTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.DocumentTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Citizenships", "Name", c => c.String(nullable: false));
        }
    }
}
