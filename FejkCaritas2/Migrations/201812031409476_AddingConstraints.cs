namespace FejkCaritas2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingConstraints : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Volunteers", "CitizenshipID", "dbo.Citizenships");
            DropForeignKey("dbo.Volunteers", "SexID", "dbo.Sexes");
            DropIndex("dbo.Volunteers", new[] { "SexID" });
            DropIndex("dbo.Volunteers", new[] { "CitizenshipID" });
            AlterColumn("dbo.Citizenships", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Volunteers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Volunteers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Volunteers", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Volunteers", "OIB", c => c.String(nullable: false, maxLength: 11));
            AlterColumn("dbo.Volunteers", "SexID", c => c.Int());
            AlterColumn("dbo.Volunteers", "CitizenshipID", c => c.Int());
            AlterColumn("dbo.Contracts", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Documents", "EndDate", c => c.DateTime());
            AlterColumn("dbo.DocumentTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ExpenseTypes", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.VolunteeringHours", "EndDate", c => c.DateTime());
            AlterColumn("dbo.Sexes", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Volunteers", "SexID");
            CreateIndex("dbo.Volunteers", "CitizenshipID");
            AddForeignKey("dbo.Volunteers", "CitizenshipID", "dbo.Citizenships", "ID");
            AddForeignKey("dbo.Volunteers", "SexID", "dbo.Sexes", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Volunteers", "SexID", "dbo.Sexes");
            DropForeignKey("dbo.Volunteers", "CitizenshipID", "dbo.Citizenships");
            DropIndex("dbo.Volunteers", new[] { "CitizenshipID" });
            DropIndex("dbo.Volunteers", new[] { "SexID" });
            AlterColumn("dbo.Sexes", "Name", c => c.String());
            AlterColumn("dbo.VolunteeringHours", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ExpenseTypes", "Name", c => c.String());
            AlterColumn("dbo.DocumentTypes", "Name", c => c.String());
            AlterColumn("dbo.Documents", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Contracts", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Volunteers", "CitizenshipID", c => c.Int(nullable: false));
            AlterColumn("dbo.Volunteers", "SexID", c => c.Int(nullable: false));
            AlterColumn("dbo.Volunteers", "OIB", c => c.String());
            AlterColumn("dbo.Volunteers", "Username", c => c.String());
            AlterColumn("dbo.Volunteers", "LastName", c => c.String());
            AlterColumn("dbo.Volunteers", "FirstName", c => c.String());
            AlterColumn("dbo.Citizenships", "Name", c => c.String());
            CreateIndex("dbo.Volunteers", "CitizenshipID");
            CreateIndex("dbo.Volunteers", "SexID");
            AddForeignKey("dbo.Volunteers", "SexID", "dbo.Sexes", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Volunteers", "CitizenshipID", "dbo.Citizenships", "ID", cascadeDelete: true);
        }
    }
}
